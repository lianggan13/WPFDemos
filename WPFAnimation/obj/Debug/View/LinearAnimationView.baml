   M S B A M L   `   `   `  ����G  CWPFAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFAnimation.ViewWPFAnimation.View  5      +    %WPFAnimation.View.LinearAnimationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WPFAnimation.View     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         Animation.Border g� AutoReverse g� RepeatBehavior �� 
TargetName �� TargetProperty	 W� To g� Duration	 �� To  Animation.Grid��%T  &	        &	 �    �� 5   
    . $ Forever��5      $ border��5      .��5      W� $ Width�5      $	 150X�5      $ 0:0:2D�5      W� 5      $ Height�5      $	 150X�5      $ 0:0:2D�5      �� 5      $ Background.Color�5      $ OrangeX�5      $ 0:0:2D�5      �� 5      $+ %(BorderBrush).(SolidColorBrush.Color)�5      $ GreenX�5      $ 0:0:2D�5       5!      �� 5#   
    .  $ Forever��5&      $ rt��5'      .��5(      W� $ Angle�5)      $	 360X�5*      $ 0:0:5D�5+      5,      5.       � Triggers 50      :� 51   
   	 :� RoutedEvent$	 Loaded��6   
 :� 
SourceName$
 border��6,   .[�52      �� #��[  6   53      :� 55   
   $	 Loaded��6   $

 grid��6,   .[�56      �� #��[ 6   57      .��5:      � 
�������.+�5;   
   �� $
��Left=�6   .+�5<      � $	��150��6   $	��150��6   .+�5=      �� -   5         ��Name$ border��5>      $��40��5?      $��40��5@      
��� � �
��� ���$��1q�5C       �� CornerRadius$ 0,0,0,0��5D      5E      � 5H      -   5         �Name$
 grid��5I      $	��100��5J      $	��100��5K       J� RenderTransformOrigin$ 0.5,0.5&�5L      z�5M      �� 5N      -   5        rt�� �� Angle$ 0Q�5N   2   .+�5R      �� 
���/���$��1q�63   ._�5S      A� $��12��5T      $��12��5U      $��Bottom=�5V      
��� ��� �� StrokeDashArray$ 2R�5X      5Y      5Z      �� 5[      $��50��6   $
��Move��6!   z�5\      T� 5]      -   5        tt�� T� X$ 0Q�5]   5    T� Y$ 0Q�6;    5_      :� 5`      $	 Button.Click��6#   .[�5a      �� .��5b      �� $ tt��6)   .��5c   "   W� 	 W� By$	 120X�5d   %   $ X�5e   %   $ 0:0:4D�5f   %   W� 5g   "   $ Y�5h   %   $	 120X�5i   %   $ 0:0:4D�5j   %    W� EasingFunction 5k   &   /  )System.Windows.Media.Animation.BounceEase  5l   *      Bounces$ 3��65      
Bounciness$ 2Q�6A   5n   #   5o      5p      5q      5s      5x      5y      5z      