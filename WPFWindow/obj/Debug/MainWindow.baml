   M S B A M L   `   `   `  ����D  @WPFWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFWindow	WPFWindow  5          WPFWindow.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WPFWindow     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  MaxSign Auto v1.6.0��5      $
��1034��5	      $	��730��5
      $
��1034��5      $	��730��5      ���#015478 � 
ResizeMode$ CanResizeWithGrip=�5       � UseLayoutRounding .  � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5      ��%    '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      UseAeroCaptionButtons .  6   ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � ��	 �� Value	 5      �� 5      
 �� 
TargetType"
 �6&   .R�5      ��  ��Name$ WindowBorder��5      #��z��5      #��z��5      ._�5       �  �Name$ 
LayoutRoot��6#   #��z��67    � RowDefinitions 5!   "   �� 5"   &   $
��Auto �64   �� 5#   &   $��* �64   .+�5(   "   � $ WindowTitlePanel��5)   %   $��30��5*   %   $��0,0,0,0q�5+   %   #��z��5,   %    � ColumnDefinitions 5-   &   �� 5.   *   $��* �6;   �� 5/   *   $
��Auto �6;   .+�52   &   �� $��12,0,0,0q�61    �� Orientation$ 
Horizontal=�6C   .+�5:   *   �� #��Z��5;   -   #��Z��5<   -   $��Center=�5=   -   $��/Resource/ttf/#iconfont)�5>   -   $��10(�5?   -   
�������$	����5A   -      IsHitTestVisibleInChrome . 5B   -   �� 5D   *   $��8,0,0,0q�5E   -   $��Center=�5F   -   #��z  5G   -   #��� ��5H   -   
�������5I   -   5J   '   �� 5M   &    ��Name$ WindowCommandButtonsPanel��5N   )   $��1��5O   )   $��0,0,-1,0q�5P   )   $��Right=�5Q   )   $ 
Horizontal=�5R   )    . .+�5[   *   ��  ��Name$ cbLang��5\   -   $��60��5]   -    �� SelectedIndex$ 1��5^   -    !  ComboBox.NonEditable.IconFont#��[  5_   -   .@�5`   .   �� $��中文��6;   �� 5a   .   $��Englisth��6;   5b   +   �� 5e   *   $��35��61   $��0,0,0,0q�6<   ��5f   .   �� 5g   2   " ��68    �� Triggers 5h   6   P� 5i   :    P� Property �@J�IsMouseOver P� Value . . �5j   >   ��  � ��	 �#14274E6[   5k   ;   5m   3   ._�5o   .   ��  ��Name$ btnMin��5p   1   -   5        $��Center=�5q   1    � Cursor$
 Hand��5s   1     Style.Button.MainWindow.Min#��[ 5t   1   5u   +   �� 5x   *   $��35��61   $��0,0,0,0q�6<   ��5y   .   �� 5z   2   " ��68    5{   6   P� 5|   :    �@J�IsMouseOver . . �5}   >   ��  � ��	 �#14274E6[   5~   ;   5�   3   ._�5�   .   �� $��Center=�69   $ 
Horizontal=�6V   .+�5�   2   �� $ btnMax��5�   5   -   5        $��0,10,0,8q�5�   5   $
 Hand��5�   5    " Style.Button.MainWindow.Normal#��[ 5�   5   �� 5�   2   $ 	btnNormal��5�   5   -   5        $��0,10,0,8q�5�   5   $
 Hand��5�   5     Style.Button.MainWindow.Max#��[ 5�   5   $y�	Collapsed=�5�   5   5�   /   5�   +   �� 5�   *   $��35��61   $��0,0,0,0q�6<   ��5�   .   �� 5�   2   " ��68    5�   6   P� 5�   :    �@J�IsMouseOver . . �5�   >   ��  � ��	 �#D146466[   5�   ;   5�   3   ._�5�   .   �� $ btnClose��5�   1   -   5        $��Center=�5�   1   $��Center=�5�   1   $
 Hand��5�   1    ! Style.Button.MainWindow.Close#��[ 5�   1   5�   +   5�   '   5�   #   �� 5�   "   $��1��63   -  'System.Windows.Input.KeyboardNavigation   	IsTabStop .  .u�5�   &   ��  ��Name$ MainContentPresenter��5�   )   #��z��5�   )      TabNavigation$ Cycle=�5�   )   5�   #   �� 5�   "    ��Name$ 
ResizeGrip��5�   %   $��1��5�   %   $��Right=�5�   %   $��Bottom=�5�   %   $y�	Collapsed=�5�   %   5�      5�       �� Triggers 5�      P� 5�       �@�WindowState$ 	Maximized=�6=   . �5�   "   ��  �� 
TargetName$ btnMax��6)    � y�$	 	Collapsed=�6S   �� 5�   "   $ 	btnNormal��6)    � y�$	 Visible=�6V   �� 5�   "   $ WindowBorder��6)    � ��$	 0q�6^   �� 5�   "   $ WindowBorder��6)   %  System.Windows.SystemParameters"   WindowResizeBorderThickness#	 Z 6V    �@��Padding�� 5�   "   $ 
LayoutRoot��6)    � ��$	 4q�6S   5�      P� 5�       �@�WindowState$ Normal=�6=   . �5�   "   �� $ btnMax��6)    � y�$	 Visible=�6S   �� 5�   "   $ 	btnNormal��6)    � y�$	 	Collapsed=�6V   5�      P� 5�       �@�WindowState$ 	Minimized=�6=   . �5�   "   �� $ btnMin��6)    � y�$	 	Collapsed=�6S   5�      ]� 5�        ]� 
Conditions  5�   "   �� 5�   &   ! �� Property! �@�WindowState" �� Value$" Normal=�6G   �� 5�   &   ! �@�
ResizeMode$" CanResizeWithGrip=�6F   /�5�   "   �� 5�   &   $ 
ResizeGrip��6-    � y�$	 Visible=�6[   5�      5�      5�      5�      .��5�      � .+�5�   
   �� $��Stretch=�5�      $��Center=�5�      
�������$��50(�5�      $��Window Client Content��5�      # �� TextAlignment$# Center=�5�      5�      5�      