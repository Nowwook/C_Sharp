/*
화면 ListBox에 log 데이터를 넣을 때 여러 스레드에서 동시 접근 시 error
> ListBox 가 만들어진 ui 스레드에서 처리하게 만듬
*/

private void AddToListBox(string LOG, ListBox listBox)
{
    try
    {
        if (listBox.InvokeRequired)  // ListBox 가 만들어진 ui 스레드가 아닌지 확인
        {
            listBox.Invoke(new Action<string, ListBox>(AddToListBox), LOG, listBox);  // 아니면 ui 스레드로 다시 AddToListBox메서드 실행
        }
        else
        {
            listBox.Items.Add(LOG);
        }
    }
    catch (Exception ex)
    {
        
    }
}
