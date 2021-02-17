#nullable disable
using Avalonia.Controls;
using Avalonia.Input;
using Core2D.ViewModels.Shapes;

namespace Core2D.Behaviors.DragAndDrop
{
    public class GroupsListBoxDropHandler : ListBoxDropHandler
    {
        public override bool Validate(object sender, DragEventArgs e, object sourceContext, object targetContext, object state)
        {
            if (e.Source is IControl && sender is ListBox listBox)
            {
                return ValidateLibrary<GroupShapeViewModel>(listBox, e, sourceContext, targetContext, false);
            }
            return false;
        }

        public override bool Execute(object sender, DragEventArgs e, object sourceContext, object targetContext, object state)
        {
            if (e.Source is IControl && sender is ListBox listBox)
            {
                return ValidateLibrary<GroupShapeViewModel>(listBox, e, sourceContext, targetContext, true);
            }
            return false;
        }
    }
}