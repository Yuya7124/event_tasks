using System.Collections.Generic;
using System.Windows.Forms;

namespace Event_Tasks.tasks_list
{
    internal class tasks_list
    {
        // 検索結果格納リスト
        private List<string> TaskTitle = new List<string>();
        private List<string> TaskDueDate = new List<string>();
        private List<string> TaskPriority = new List<string>();

        // 動的に追加するツール
        private List<Label> TaskNumLabel = new List<Label>();
        private List<Label> TaskTitleLabel = new List<Label>();
        private List<Label> PriorityLabel = new List<Label>();
        private List<Label> DueDateLabel = new List<Label>();
        private List<Button> DelTaskButton = new List<Button>();
    }
}
