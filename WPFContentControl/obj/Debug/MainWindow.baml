   M S B A M L   `   `   `  ����L  HWPFContentControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPFContentControl.CommonWPFContentControl.Common  5      5clr-namespace:WPFContentControlWPFContentControl  5      ?$clr-namespace:WPFContentControl.ViewWPFContentControl.View  5	      "    WPFContentControl.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9common&clr-namespace:WPFContentControl.Common     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WPFContentControl     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3vm$clr-namespace:WPFContentControl.View     5	        � Title$  
MainWindow��5
      $
��1250��5      $	��800��5       � DataContext 5         WPFContentControl.MainVM  5   
   -   5        VM��5       � 	Resources 5         RadioBtnStyle.Navigation �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName  ShowUserStoryboard �� 
TargetName �� TargetProperty	 W� To g� Duration  CollapseStoryboard��%W  &	        &	 d    &	 �    �� 5   
   " 	�61   .�5      ��  � ��$ 13(�6)   �� 5       � ��$
 20,4q�6'   �� 5       � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " 	�6&   .R�5      �� $ radioButtonBorder��5      
������ $ 8��5      ._�5      �� #��z��5   !   $��Center=�5    !   $��Center=�5!   !   #��z��5"   !   #��z��5#   !   5$      	 5%      P� 5)      
 �@d�	IsChecked$
 trueY�6;   . �5*   "   �� $ radioButtonBorder��6)    � �� �	#44FFFFFF6^   5+      5-      5/      50      �� 51   
   .��52      W� $ tt��53      $ X�54      $ 0X�55      $ 0:0:0.2D�56      57      �� 59   
   .��5:      W� $ tt��5;      $ X�5<      $ 0:0:0.1D�5=      5>      5A       � Triggers 5B      :� 5C   
    :� RoutedEvent$ ToggleButton.Checked��6    :� 
SourceName$ 	usrRadBtn��6:   .[�5D      �� #��[ 6   5E      :� 5F   
   $ ToggleButton.Unchecked��6   $ 	usrRadBtn��6<   .[�5G      �� #��[ 6   5H      .��5J      � .+�5K   
   �� $	��200��5L      $	��Top=�5M      ���#007DFA$ 5,5,0,0��5O      � 5P   
   $��50,20q�6    � RowDefinitions 5Q      �� 5R      $��65 �6    �� 5S      $��35 �6    �� 5T      .+�5V      �� $��15,0,0,0q�6   $��Center=�6+   .+�5W      �� $��通用测试管理平台��5X      $��20(�5Y      
�������5Z      �� 5[      $��GTS-Manager��5\      $��10(�5]      ���	#88DDDDDD5^      5_      �� 5a      $��1��5b      $��Center=�5c       �� Orientation$ 
Horizontal=�5d      .+�5e      	� /   )WPFContentControl.Common.ContentTypeDpObj   ContentType%   WPFContentControl.View.HomePage"  5f      $
��Home��5i       d� 	IsChecked$
 TrueY�5j      #���   5k      ��5g      �� *NavigateCmd+��5h      ��  �� RelativeSource ��  �� Mode$
 Self=�5k      	� 5l      '   !WPFContentControl.View.CenterPage"  5m      $��Center��5p      #���   5q      ��5n      �� *NavigateCmd+��5o      ��  �� $
 Self=�5q      	� 5r      (   "WPFContentControl.View.SettingPage"  5s      $��Setting��5v      #���   5w      ��5t      �� *NavigateCmd+��5u      ��  �� $
 Self=�5w      	� 5x      -   5         	�Name$ 	usrRadBtn��5y      $��Right=�5z      $
��User��5{      #���   5|      5}      �� 5~      $��2��5      $��Stretch=�5�      ��5�      �� *MainContent+5�      �� 5�   
   $	��240��5�      $��Right=�5�      
�������
���   �$��4q�5�      z�5�      T� 5�      -   5        tt�� T� X$	 245Q�5�   1   5�      5�      5�      