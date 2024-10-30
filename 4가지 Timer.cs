/*
System.Timers.Timer                 서버 및 백그라운드 작업에 적합한 멀티스레드 타이머.
System.Threading.Timer              스레드 풀에서 실행되는 타이머로, 고급 스레드 제어가 필요할 때 사용.
System.Windows.Forms.Timer          Windows Forms 애플리케이션에서 UI와 안전하게 상호작용할 수 있는 타이머.
System.Windows.Threading.DispatcherTimer        WPF 애플리케이션에 최적화.
*/

/*
1. System.Timers.Timer
주요 특징: 서버 또는 백그라운드 작업에 사용하기 적합한 타이머입니다. 주기적으로 이벤트를 발생시키고, 별도의 스레드에서 콜백 메서드를 실행합니다.
사용 예시: 서버 애플리케이션, 백그라운드 작업, 콘솔 애플리케이션에서 타이머 기능이 필요할 때 사용됩니다.
이벤트: Elapsed 이벤트를 통해 타이머가 지정된 간격으로 실행됩니다.
스레드: 타이머가 새로운 스레드에서 실행되기 때문에 UI 업데이트에는 적합하지 않습니다.
*/
System.Timers.Timer timer = new System.Timers.Timer(1000); // 1초 간격
timer.Elapsed += OnTimedEvent;
timer.AutoReset = true;
timer.Enabled = true;

private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
{
    Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
}


/*
2. System.Threading.Timer
주요 특징: 주로 스레드 기반의 타이머로, 백그라운드에서 주기적인 작업을 수행할 때 사용됩니다. 고급 스레드 제어가 필요할 때 유용합니다.
사용 예시: 서버 또는 백그라운드 스레드에서 일정 시간 간격으로 작업을 수행해야 할 때 사용됩니다.
스레드: 새로운 스레드 풀에서 실행되며, UI 스레드에서 실행되지 않기 때문에 UI 업데이트에는 사용하지 않습니다.
*/
System.Threading.Timer timer = new System.Threading.Timer(
    callback: TimerCallback,
    state: null,
    dueTime: 1000,       // 1초 후 시작
    period: 2000);       // 2초마다 실행

private static void TimerCallback(Object o)
{
    Console.WriteLine("Timer callback executed.");
}


System.Threading.Timer timerThread = new System.Threading.Timer( 실행할Logic );
timerThread.Change( 이 시간이 흐르고 실행 , 실행 후 이 시간 뒤에 다시 실행 );

timerThread.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);  // 무한 대기


/*
3. System.Windows.Forms.Timer
주요 특징: 윈도우 폼 애플리케이션에서 주로 사용되는 타이머로, 주기적으로 UI 관련 작업을 수행할 때 사용됩니다.
사용 예시: 주로 GUI 프로그램에서 UI 업데이트와 같은 작업을 주기적으로 수행할 때 사용됩니다.
스레드: UI 스레드에서 실행되며, UI 컨트롤과 안전하게 상호작용할 수 있습니다.
*/
System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
timer.Interval = 1000; // 1초 간격
timer.Tick += new EventHandler(OnTimedEvent);
timer.Start();

private void OnTimedEvent(Object sender, EventArgs e)
{
    label1.Text = DateTime.Now.ToString("HH:mm:ss");
}


/*
4. System.Windows.Threading.DispatcherTimer
주요 특징: WPF 애플리케이션에서 주로 사용되는 타이머로, UI 스레드에서 주기적으로 작업을 수행할 때 사용됩니다.
사용 예시: WPF GUI 프로그램에서 UI 업데이트와 같은 작업을 주기적으로 수행할 때 사용됩니다.
스레드: UI 스레드(Dispatcher 스레드)에서 실행되며, UI 요소와 직접적으로 안전하게 상호작용할 수 있습니다.
*/

using System.Windows.Threading;

// 타이머 인스턴스 생성
DispatcherTimer timer = new DispatcherTimer();
timer.Interval = TimeSpan.FromSeconds(1); // 1초 간격
timer.Tick += OnTimedEvent;
timer.Start();

private void OnTimedEvent(object sender, EventArgs e)
{
    // UI 요소에 직접 접근 가능
    textBlock.Text = DateTime.Now.ToString("HH:mm:ss");
}



