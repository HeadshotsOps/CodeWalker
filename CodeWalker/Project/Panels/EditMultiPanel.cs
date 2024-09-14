using CodeWalker.GameFiles;
using SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.Project.Panels
{
    public partial class EditMultiPanel : ProjectPanel
    {
        public ProjectForm ProjectForm;
        public MapSelection[] Items { get; set; }
        public MapSelection MultiItem;

        private bool populatingui = false;
        private object mloInstance;

        public EditMultiPanel(ProjectForm owner)
        {
            ProjectForm = owner;
            InitializeComponent();
        }

        public void SetItems(MapSelection[] items)
        {
            Items = items;
            Tag = items;
            LoadItems();
            UpdateFormTitle();
        }

        private void UpdateFormTitle()
        {
            Text = (Items?.Length ?? 0).ToString() + " item" + ((Items?.Length == 1) ? "" : "s");
        }


        private void LoadItems()
        {
            MultiItem = new MapSelection();
            MultiItem.WorldForm = ProjectForm.WorldForm;
            MultiItem.Clear();
            MultiItem.SetMultipleSelectionItems(Items);

            if (Items == null)
            {
                PositionTextBox.Text = string.Empty;
                RotationQuatBox.Value = Quaternion.Identity;
                ScaleTextBox.Text = string.Empty;
                ItemsListBox.Items.Clear();
            }
            else
            {
                populatingui = true;


                PositionTextBox.Text = FloatUtil.GetVector3String(MultiItem.MultipleSelectionCenter);
                RotationQuatBox.Value = MultiItem.MultipleSelectionRotation;
                ScaleTextBox.Text = FloatUtil.GetVector3String(MultiItem.MultipleSelectionScale);
                ItemsListBox.Items.Clear();
                foreach (var item in Items)
                {
                    ItemsListBox.Items.Add(item);
                }

                populatingui = false;


            }


        }

        private void PositionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Items == null) return;
            if (populatingui) return;
            var v = FloatUtil.ParseVector3String(PositionTextBox.Text);

            var wf = ProjectForm.WorldForm;
            if (wf != null)
            {
                wf.BeginInvoke(new Action(() =>
                {
                    wf.ChangeMultiPosition(Items, v, false);
                }));
            }

        }

        private void RotationQuatBox_ValueChanged(object sender, EventArgs e)
        {
            if (Items == null) return;
            if (populatingui) return;
            var q = RotationQuatBox.Value;

            var wf = ProjectForm.WorldForm;
            if (wf != null)
            {
                wf.BeginInvoke(new Action(() =>
                {
                    wf.ChangeMultiRotation(Items, q, false);
                }));
            }
        }

        private void ScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Items == null) return;
            if (populatingui) return;
            var v = FloatUtil.ParseVector3String(ScaleTextBox.Text);

            var wf = ProjectForm.WorldForm;
            if (wf != null)
            {
                wf.BeginInvoke(new Action(() =>
                {
                    wf.ChangeMultiScale(Items, v, false);
                }));
            }

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flags3_ValueChanged(object sender, EventArgs e)
        {
            if (Items == null) return;
            if (populatingui) return;

            foreach (MapSelection ms in Items)
            {
                ms.PathNode.Flags3 = 214;//Convert.ToByte(flags3.Value);
            }
        }

        private void roomIdUpDown_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Deprecated mod by headshots"); //broke on merging on 14/09
            //bool hasMlo = true;
            //int newRoomIdx = Convert.ToInt32(roomIdUpDown.Value);
            //foreach (MapSelection ms in Items)
            //{
            //    YmapEntityDef mloInstanceEntity = ms.EntityDef.MloParent;
            //    if (mloInstanceEntity is null)
            //    {
            //        hasMlo = false;
            //        MessageBox.Show("Not all entities have an MLO parent!");
            //    }
            //    MloArchetype mloArch = mloInstanceEntity.Archetype as MloArchetype;

            //    MCEntityDef mcEnt = mloInstanceEntity.MloInstance.TryGetArchetypeEntity(mloInstanceEntity);
            //    ProjectForm.DeleteMloEntity(ms.EntityDef);
            //    ProjectForm.NewMloEntity(mloArch, newRoomIdx, ms.EntityDef.CEntityDef, false, true);
            //}
        }

        class PropPlane
        {
            public Vector2 v1;
            public Vector2 v2;
            public Vector2 v3;
            public Vector2 v4;

            public override string ToString()
            {
                return $"PropPlane(" +
                    $"Vec2({v1.X},{v1.Y}),"+
                    $"Vec2({v2.X},{v2.Y}),"+
                    $"Vec2({v3.X},{v3.Y}),"+
                    $"Vec2({v4.X},{v4.Y}),\n),\n";
            }

            public void Rotate(Quaternion rotation)
            {
                Matrix rotationMatrix = Matrix.RotationQuaternion(rotation);
                Vector2.TransformCoordinate(ref v1, ref rotationMatrix, out v1);
                Vector2.TransformCoordinate(ref v2, ref rotationMatrix, out v2);
                Vector2.TransformCoordinate(ref v3, ref rotationMatrix, out v3);
                Vector2.TransformCoordinate(ref v4, ref rotationMatrix, out v4);
            }
            public void Translate(Vector2 worldPos)
            {
                v1 += worldPos;
                v2 += worldPos;
                v3 += worldPos;
                v4 += worldPos;
            }
        }

        private void btnMinimapProps_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            string propPlanesText = "";

            txtBlenderScript.Text = "";
            foreach (MapSelection ms in Items)
            {
                YmapEntityDef mloInstanceEntity = ms.EntityDef.MloParent;
                MloArchetype mloArch = mloInstanceEntity.Archetype as MloArchetype;
                MCEntityDef mcEnt = mloInstanceEntity.MloInstance.TryGetArchetypeEntity(ms.EntityDef);
                Archetype entArch = ms.EntityDef.Archetype;
                PropPlane pp = new PropPlane
                {
                    v2 = new Vector2(entArch.BBMin.X, entArch.BBMin.Y),
                    v1 = new Vector2(entArch.BBMin.X, entArch.BBMax.Y),
                    v3 = new Vector2(entArch.BBMax.X, entArch.BBMin.Y),
                    v4 = new Vector2(entArch.BBMax.X, entArch.BBMax.Y),
                };
                pp.Rotate(new Quaternion(mcEnt.Data.rotation.X, mcEnt.Data.rotation.Y, -mcEnt.Data.rotation.Z, mcEnt.Data.rotation.W));
                pp.Translate(new Vector2(mcEnt.Data.position.X, mcEnt.Data.position.Y));

                propPlanesText+= pp.ToString();

            }

            string planesStr = $"planes = [{propPlanesText}]";
            txtBlenderScript.Text=planesStr;
        }
    }
}
