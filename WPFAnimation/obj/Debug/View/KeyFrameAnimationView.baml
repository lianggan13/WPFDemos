   M S B A M L   `   `   `  ����G  CWPFAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFAnimation.ViewWPFAnimation.View  5      -    'WPFAnimation.View.KeyFrameAnimationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WPFAnimation.View     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5       ��Name   
storyboard g� RepeatBehavior g� AutoReverse �� 
TargetName �� TargetProperty �� KeyTime �� Value��%�  &	        �� 5   
   $ 
storyboard��6   $ Forever��6=   .��53      ��  .  $ Forever��55      $ 
txtWaiting��56      $
 Text�57      .�58      a� $ 0:0:1��6)   $ .��69   a� 59      $ 0:0:2��6)   $ ..��69   a� 5:      $ 0:0:3��6)   $	 ...��69   a� 5;      $ 0:0:4��6)   $
 ....��69   a� 5<      $ 0:0:5��6)   $ .....��69   a� 5=      $ 0:0:6��6)   $ ......��69   5>      5@      5A      .��5C      � 
�������.+�5D   
   �� $��Center=�6   .+�5E      �� -   5         ��Name$
 rect��5F      $	��100��5G      $	��100��5H      
��� ���5I      � 5K        5L      	 �� 
TargetType
 �� Property �� Value��%�   '��       �� 5M      "	 ��6   .�5N      �� 
 � ��$	 100��62   �� 5O      
 � ��$	 100��63   �� 5P      
 � ��
 ����61   �� 5Q      
 �@J�RenderTransformOrigin$ 0.5,0.5&�6B   5R      5S      .+�5T      �� z�5U      V� 5V      .~�5X      ��  �� ScaleX$ 2Q�6-    �� ScaleY$	 0.5Q�68   �� 5Y       �� AngleX$ 60Q�6,    �� AngleY$ 0Q�68   �� 5Z      -   5        rt�� �� Angle$ 0Q�5Z   :   5[      5]      �� 5^      z�5_      V� 5`      .~�5b      �� $	 0.5Q�6-   $ 2Q�6:   �� 5c      $ 0Q�6,   $	 -60Q�67   �� 5d      -   5        rt2��$ 0Q�5d   ;   5e      5g      5h      � 5j      $��80��6   $��80��6   .+�5k      �� 
���  ��$��1q�5m       J� RenderTransformOrigin$ 0.5,0.5&�5n      z�5o      �� 5p      -   5        rt3��$ 0Q�5p   7   ._�5r      A� $��10��5s      $��10��5t      $��Bottom=�5u      
��� ���5v      5�      5�      �� 5�      -   5         ��Name$ 
txtWaiting��5�      $��0,50,0,0q�5�      $�� ��5�      5�      5�      �� 5�   
   $��Right=�5�      $��Bottom=�5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� $��0,0,30,0q�6   $��Start Animation��6'    � Triggers 5�      :� 5�       :� RoutedEvent$ Button.Click��6#   .[�5�      �� -   5         ��Name$ st��5�   *   #��[  67   5�      :� 5�      $ UIElement.MouseLeave��6#   .[�5�      ��  �� BeginStoryboardName$ st��6+   5�      :� 5�      $ UIElement.MouseEnter��6#   .[�5�      ?� $ st��6*   5�      5�      5�      5�      5�      