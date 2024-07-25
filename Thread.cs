System.Threading.Timer timerThread = null;

timerThread = new System.Threading.Timer( 실행할Logic );
timerThread.Change( 이 시간이 흐르고 실행 , 실행 후 이 시간 뒤에 다시 실행 );

timerThread.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);  // 무한 대기
