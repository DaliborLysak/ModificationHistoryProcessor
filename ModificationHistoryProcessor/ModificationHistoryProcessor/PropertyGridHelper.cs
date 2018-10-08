using System.Windows.Forms;

namespace ModificationHistoryProcessor
{
    public class PropertyGridHelper
    {
        public PropertyGridHelper(PropertyGrid propertyGrid)
        {
            PropertyGrid = propertyGrid;
        }

        ModificationHistorySettings ActualSettings = new ModificationHistorySettings();
        PropertyGrid PropertyGrid;

        public void SetSettings()
        {
            ActualSettings = new ModificationHistorySettings();
            PropertyGrid.SelectedObject = ActualSettings;
        }

        private void ResetSelectedItem()
        {
            PropertyGrid.ResetSelectedProperty();
        }

        private void SelectAndResetItem(GridItem item)
        {
            item.Select();
            ResetSelectedItem();
        }

        private void ResetSettingsInCategory(GridItem categoryItem)
        {
            foreach (GridItem item in categoryItem.GridItems)
            {
                SelectAndResetItem(item);
            }
        }

        public void ResetCategoriesSettings()
        {
            GridItemCollection items =
                PropertyGrid.SelectedGridItem.GridItemType == GridItemType.Category ?
                PropertyGrid.SelectedGridItem.Parent.GridItems :
                PropertyGrid.SelectedGridItem.Parent.Parent.GridItems;

            foreach (GridItem categoryItem in items)
            {
                if (categoryItem.GridItemType == GridItemType.Category)
                {
                    ResetSettingsInCategory(categoryItem);
                }
            }
        }
    }
}
