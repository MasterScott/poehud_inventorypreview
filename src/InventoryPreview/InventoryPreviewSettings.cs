using SharpDX;
using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace InventoryPreview
{
    public sealed class InventoryPreviewSettings : SettingsBase
    {
        public InventoryPreviewSettings()
        {
            Enable = false;
            AutoUpdate = true;
            FullBorderColor = new Color(255, 0, 0, 255);
            FullBackgroundColor = new Color(255, 0, 0, 255);
            EmptyBorderColor = new Color(255, 255, 255, 255);
            EmptyBackgroundColor = new Color(255, 255, 255, 255);
            CellBorderThickness = new RangeNode<int>(1, 0, 10);
            CellSize = new RangeNode<int>(30, 1, 100);
            CellPadding = new RangeNode<int>(1, 0, 10);
            PositionX = new RangeNode<float>(28.0f, 0.0f, 100.0f);
            PositionY = new RangeNode<float>(83.0f, 0.0f, 100.0f);
            TextBackgroundColor = new ColorBGRA(0, 0, 0, 178);
        }

        [Menu("Auto Update")]
        public ToggleNode AutoUpdate { get; set; }
        
        [Menu("Full Cells", 2)]
        public EmptyNode FullCells { get; set; }
        [Menu("Border Color", 21, 2)]
        public ColorNode FullBorderColor { get; set; }
        [Menu("Background Color", 22, 2)]
        public ColorNode FullBackgroundColor { get; set; }

        [Menu("Empty Cells", 1)]
        public EmptyNode EmptyCells { get; set; }
        [Menu("Border Color", 11, 1)]
        public ColorNode EmptyBorderColor { get; set; }
        [Menu("Background Color", 12, 1)]
        public ColorNode EmptyBackgroundColor { get; set; }

        [Menu("Cell Border Thickness")]
        public RangeNode<int> CellBorderThickness { get; set; }
        [Menu("Cell Size")]
        public RangeNode<int> CellSize { get; set; }
        [Menu("Cell Padding")]
        public RangeNode<int> CellPadding { get; set; }
        [Menu("Position X")]
        public RangeNode<float> PositionX { get; set; }
        [Menu("Position Y")]
        public RangeNode<float> PositionY { get; set; }
        [Menu("Text Background Color")]
        public ColorNode TextBackgroundColor { get; set; }
    }
}
