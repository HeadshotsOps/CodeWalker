using CodeWalker.GameFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.Project.Panels
{
    public partial class GenerateDeltasPanel : ProjectPanel
    {
        public class MapDataDeltas
        {
            public MetaHash MapDataName { get; set; }
            public List<CEntityDef> RemovedEntities { get; set; }

            public MapDataDeltas(MetaHash mapName)
            {
                MapDataName = mapName;
                RemovedEntities = new List<CEntityDef>();
            }

            public string GetScriptString(bool commentNames)
            {
                if (RemovedEntities.Count == 0)
                {
                    return "";
                }
                StringBuilder sb = new StringBuilder();
                
                int nameHash = MetaTypes.ConvertData<int>(MetaTypes.ConvertToBytes(MapDataName));
                sb.Append($"mapdataPatches[{nameHash}] ="); if (commentNames) { sb.Append($" //{MapDataName}\n"); }
                sb.AppendLine("[");
                foreach (CEntityDef entity in RemovedEntities)
                {
                    sb.Append($"\t{(int)entity.guid},"); if (commentNames) {sb.Append($" //{entity.archetypeName},"); }
                    sb.AppendLine();
                }
                sb.AppendLine("]");

                return sb.ToString();
            }
        }
        public ProjectForm ProjectForm { get; set; }
        public ProjectFile CurrentProjectFile { get; set; }

        public List<YmapFile> LoadedYmaps { get; set; } = new List<YmapFile>();
        public List<MapDataDeltas> AllDeltas { get; set; }


        public GenerateDeltasPanel(ProjectForm projectForm)
        {
            ProjectForm = projectForm;
            AllDeltas = new List<MapDataDeltas>();
            InitializeComponent();
        }

        public void SetProject(ProjectFile project)
        {
            CurrentProjectFile = project;
        }

        string GenerateScript()
        {
            StringBuilder sb = new StringBuilder();
            foreach (MapDataDeltas deltas in AllDeltas)
            {
                sb.Append(deltas.GetScriptString(true));
            }
            return sb.ToString();
        }
        private string[] ShowOpenDialogMulti(string filter, string filename)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = filename;
            dialog.Filter = filter;
            dialog.Multiselect = true;
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return null;
            }
            return dialog.FileNames;
        }
        private void btn_SelectFiles_Click(object sender, EventArgs e)
        {
            string[] files;
            LoadedYmaps = new List<YmapFile>();
            AllDeltas = new List<MapDataDeltas>();
            string[] filetypes = {
                "All supported|*.ymap",
                "Ymap files|*.ymap",
            };

            files = ShowOpenDialogMulti(string.Join("|", filetypes), string.Empty);

            lstbx_LoadedFiles.Items.Clear();

            foreach (string file in files)
            {
                
                byte[] bytes = File.ReadAllBytes(file);
                
                var fe = CreateFileEntry(Path.GetFileName(file), file, ref bytes);

                YmapFile ymap = RpfFile.GetFile<YmapFile>(fe, bytes);


                //ProjectForm.WorldForm.GameFileCache.LoadFile<YmapFile>(ymap);
                LoadedYmaps.Add(ymap);
                lstbx_LoadedFiles.Items.Add(ymap.CMapData.name);


                YmapFile vanillaYmap = ProjectForm.WorldForm.GameFileCache.GetYmap(ymap.CMapData.name);
               
                if (vanillaYmap == null)
                {
                    MessageBox.Show(ymap.CMapData.name.ToString() + "does not have a vanilla equivalent");
                    break;
                }

                ProjectForm.WorldForm.GameFileCache.LoadFile<YmapFile>(vanillaYmap);
                DeltaYmap(vanillaYmap, ymap);

            }

            txt_ScriptOutput.Text = GenerateScript();
        }

        private RpfFileEntry CreateFileEntry(string name, string path, ref byte[] data)
        {
            //this should only really be used when loading a file from the filesystem.
            RpfFileEntry e = null;
            uint rsc7 = (data?.Length > 4) ? BitConverter.ToUInt32(data, 0) : 0;
            if (rsc7 == 0x37435352) //RSC7 header present! create RpfResourceFileEntry and decompress data...
            {
                e = RpfFile.CreateResourceFileEntry(ref data, 0);//"version" should be loadable from the header in the data..
                data = ResourceBuilder.Decompress(data);
            }
            else
            {
                var be = new RpfBinaryFileEntry();
                be.FileSize = (uint)data?.Length;
                be.FileUncompressedSize = be.FileSize;
                e = be;
            }
            e.Name = name;
            e.NameLower = name?.ToLowerInvariant();
            e.NameHash = JenkHash.GenHash(e.NameLower);
            e.ShortNameHash = JenkHash.GenHash(Path.GetFileNameWithoutExtension(e.NameLower));
            e.Path = path;
            return e;
        }
        bool ContainsEntity(uint entityGuid, MetaHash originalArchetypeName, YmapFile fileToCheck)
        {
            if (fileToCheck?.AllEntities == null)
            {
                return false;
            }

            foreach (var e in fileToCheck.AllEntities)
            {
                if (e.CEntityDef.guid == entityGuid)
                {
                    if (e.CEntityDef.archetypeName == originalArchetypeName && !(e.CEntityDef.scaleXY < 0.0001f && e.CEntityDef.scaleZ < 0.0001f))
                    {
                        return true;
                    }
                   
                    return false;
                }
            }
            return false;
            return fileToCheck.AllEntities.Any(e => e.CEntityDef.guid == entityGuid && e.CEntityDef.archetypeName == originalArchetypeName);
        }

        void DeltaYmap(YmapFile vanilla, YmapFile edited)
        {
            if (vanilla.AllEntities == null)
            {
                return;
            }
            MapDataDeltas deltas = new MapDataDeltas(vanilla.CMapData.name);
            foreach (var entity in vanilla.AllEntities)
            {
                
                if (!ContainsEntity(entity.CEntityDef.guid, entity.CEntityDef.archetypeName, edited))
                {
                    deltas.RemovedEntities.Add(entity.CEntityDef);
                }
            }
            AllDeltas.Add(deltas);
        }
    }
}
