   M S B A M L   `   `   `  ����H  DMyMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MyMediaPlayerMyMediaPlayer  5   	       MyMediaPlayer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MyMediaPlayer     5   	   -   5          � Title$  
MainWindow��5   	   $	��500��6   $	��650��6,   $	��500��6;   $	��650��6H    � WindowStartupLocation$ CenterScreen=�6k   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      6   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,    � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5      6!   �� 5      $
��auto �6   6.   �� 5      $
��auto �6   6.   �� 5      $
��auto �6   6.   �� 5      6"   �� 5      $
��auto �6   6.   �� 5      $
��auto �6   6.   .+�5   
   �� -   5        $��btn_Stop��5      $��3��6!   $��2��6.      BorderTemplate#��[  6U     LightControlShadowEffect J� Effect# [ 6�   .��5      �� $��18��6   $��18��6#    �� Stretch$
 Fill=�6/   
�������6>   5      �� 5   
   -   5        $��	btn_Start��5      $��3��6"   $��3��6/   #��[  6W   # [ 6�   .��5      F� $��12.9999��6   $��20��6#   $ Uniform=�6/   
�������  
playStyle0#��[ 6M   5      �� 5    
   -   5        $��	btn_Pause��5       $��3��6"   $��4��6/   #��[  6W   # [ 6�   .��5!      F� $��14��6   $��18��6   $
 Fill=�6*   
�������  pauseStyle0#��[ 6E   5"      �� 5#   
   -   5        $��	btn_Sound��5#      $��3��6"   $��6��6/   #��[  6?   $��25��6j   $��25��6u   $��55,5,5,5q�6�   # [ 6�   .��5$      F� -   5        $��
sound_path��5$      $��20��6%   $��12��60   $ Uniform=�6<   
�������  sound_3Style0#��[ 6Z   5%      �� 5&   
   -   5        $��	slr_sound��5&      $��3��6"   $��7��6/   $��3q�6?   $��Center=�6J    � Minimum$ 0Q�6�    � Maximum$ 1Q�6�    � Value$	 0.5Q�6�   �� 5'   
   -   5        $��	slr_video��5'   u   	 ^� InitialShowDelay$	 0��6   
 ^� ShowDuration$
 10000��65    �� IsMoveToPointEnabled . $��2��6�   $��1��6�   $��6��6�   $��3q�6�   $��Center=�6�   $ 1Q�6]   � ToolTip 5(      _� 5)      -	   5        $��slr_video_tool��5)       _� 	Placement$ 
MousePoint=�61    _� VerticalOffset$	 -40��6H   6~   5+      �� 5,   
   -
   5        $��lb_time_end��5,      $��2��6#   $��3q�60   $��00:00:00��6;   $��Center=�6N   $��Center=�6i   6�   �� 5-   
   -   5        $��lb_time_all��5-      $��2��6#   $��7��60   $��3q�6@   $��00:00:00��6K   $��Center=�6^   $��Center=�6y   6�   r� 5.   
   -   5        $��
media_main��5.      $��1��6)   $��8��66    r� LoadedBehavior$ Manual=�6J    r� UnloadedBehavior$
 Stop=�6b   6�   9� 5/   
   -   5        $��exp_main��5/      $��1��6#   $��6��60   $��2��6@    9� ExpandDirection$
 Left=�6T   .��50      �� -   5        $��lsb_exp��50      ��6%   Z� ��6<   Z� 6�   51      o� 52   
   -   5        $��	menu_main��52      $��8��6    .@�53      m� $��Файл��6   .@�54      m� -   5        $��	menu_open��54      $ ��Открыть файл...��6,   6E   m� 55      -   5        $��menu_add��55      $2��,Добавить в список файл...��6+   6g   m� 56      -   5        $��
menu_close��56      $��Закрыть��6-   6>   57      58      59      5:      