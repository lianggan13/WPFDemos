   M S B A M L   `   `   `  ����B  >WPFPath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFPath.UC
WPFPath.UC  5      $    WPFPath.UC.CircularProgressBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WPFPath.UC     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray��%�   &	        �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�5       . #��� ��5      $	 1 2R�5      $��1��5      5      5      5      5       � DataContext 5      &    WPFPath.UC.CircularProgressBarVM  5   
   -   5        VM��5   &   .��5      � -   5         �Name$ layout��5      ��6   ��  �� RelativeSource �� *Self+ �� Path$ Width�.+�5    
   A� 
�������$��6��5$      ��5!      �� 	 �� ElementName$	 layout��$ ActualWidth���5"      ��  �� *Self+$ Width�
 J� Effect
 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         ShadowDepth$ 0Q�6#      	Direction$ 0Q�64      Color$ White��6B      
BlurRadius$ 5Q�6P   6b   5(      F� 5,   
    �� StrokeStartLineCap$ Round=�5-       �� StrokeEndLineCap$ Round=�5.      
��� ���$��4��51      ��5/      �� *
PathData+51      �� 54   
   -   5         ��Name$ txtAngle��55      $��20��56      $
��Left=�57      $	��Top=�58      $��90��59      .��6    J� InputBindings 5:      �� 5;      
 �� Key$ Enter��5<       �� Command 5=      �� *AngleChangedCmd+ �� CommandParameter 5>      �� $	 txtAngle��.��5?   %   5@      (� 5C   
   $��60q�6   $y�	Collapsed=�6   .��5D      d� $��25��5E      $��25��5F      $��Center=�5G      $��Center=�5H      
��� �|�$��Start��5L      $��9(�5M      ��5J      �� *RotateAngleCmd+��5K      ��  ��  �� Mode$
 Self=���5N      �� 5O       �� 
TargetType" d�6&   .R�5P      ��  ��Name$ border��5Q      #��z��5R      #��z��5S      #��z��5T       �� CornerRadius$ 15��5U       . ._�5W      ��  ��Name$ contentPresenter��5X   !   #��z��5Y   !   #��z��5Z   !   #��z��5[   !   |�.  ��. # z 5^   !   5_       �� Triggers 5`      P� 5a       P� Property �@d�	IsChecked P� Value$
 trueY�6;   . �5b   "   ��  �� 
TargetName$ contentPresenter��6)    � ��$
 Stop��6Z   �� 5c   "   $ border��6)    � ��
 �  ��6S   5d      5f      5h      5i      (� 5k   
   $��14q�6   .��5l      �� $��Center=�6   $��Center=�64   
���   ��� 5m      $��20(�6   �6$   �� *CurrentAngle+ �� StringFormat$	 {0}�� �� 5n      $�%��6   5o      5p      5w      5x      