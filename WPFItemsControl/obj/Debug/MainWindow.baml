   M S B A M L   `   `   `  ����J  FWPFItemsControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFItemsControl.AssetsWPFItemsControl.Assets  5      D @WPFCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullN5clr-namespace:WPFCommon.Converters;assembly=WPFCommonWPFCommon.Converters 5      1clr-namespace:WPFItemsControlWPFItemsControl  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      Q MLiveCharts, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8df;,clr-namespace:LiveCharts;assembly=LiveCharts
LiveCharts 5
      E'clr-namespace:WPFItemsControl.ViewModelWPFItemsControl.ViewModel  5           WPFItemsControl.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      4ass$clr-namespace:WPFItemsControl.Assets     5      K	converter5clr-namespace:WPFCommon.Converters;assembly=WPFCommon     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WPFItemsControl     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5	      =lvcs,clr-namespace:LiveCharts;assembly=LiveCharts     5
      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      6vm'clr-namespace:WPFItemsControl.ViewModel     5        � Title$  
MainWindow��5      $
��1200��5      $	��450��5       � DataContext 5      &    WPFItemsControl.ViewModel.MainVM  5   
   -   5        VM��5       � 	Resources 5      /  )WPFCommon.Converters.BoolToArrowConverter   BoolToArrowConverter/  )WPFCommon.Converters.BoolToBrushConverter  BoolToBrushConverter��%:   &	        &	        5   
   6)     5   
   6)   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   $��35��6*   �� 5      .+�5   
   �� ��6   �� *CourseSelections+��5      �� 5       .R�5!      $�  $� Orientation$ 
Horizontal=�6-   5"      ��5$      �� 5%      .R�5&      	� -   5        $	��5,0q�5'      $��Center=�5(       	� 	GroupName$ Course��5+      ��5*      �� *
CourseName+��5,      �� 5-       �� 
TargetType" 	�6.   .R�5.   "   ��  ��Name$
 back��5/   %   ���#EEE �� CornerRadius$ 5��51   %   ._�52   &   �� $
��15,4q�53   )   $��Center=�54   )   $��Center=�55   )   #��z��56   )   57   #   	 �� Triggers	 58   "   P� 59   &   
 P� Property
 �@d�	IsChecked P� Value$
 TrueY�6C   . �5:   *   ��  �� 
TargetName$
 back��61    �� Property � �� �� Value
 � ���6Y   �� 5;   *    � ��
 �����6G   5<   '   5>      5A      5B      5D      �� 5F   
   -   5         ��Name$	 ccs��5G      $��1��5H      ��5I      �� *CourseSeriesList+��5J      �� 5K      .R�5L      $� 5M      ��5O      7   1WPFItemsControl.Assets.CourseDataTemplateSelector  5P         RealTemplate 5Q      �� 5R      .R�5S      �� $	��0,5q�5T   !   
�������$ 10��5V   !    J� Effect 5W   "   3  -System.Windows.Media.Effects.DropShadowEffect  5X   &      
BlurRadius$ 10Q�5Y   )      	Direction$ 0Q�5Z   )      Opacity$	 0.2Q�5[   )      ShadowDepth$ 0Q�5\   )      Color$
 Gray��5]   )   ._�5_   "   � $��70��6'    � ColumnDefinitions 5`   &   �� 5a   *   �� 5b   *   �� 5c   *   $
��4.5* �6;   .+�5e   &   �� $��10,10q�5f   )   ���#DDD$��0,0,1,0q�5h   )   �� 5j   &   $��Center=�5k   )   $��Center=�5l   )   ���#444��5n   )   �� *
CourseName+�� 5o   &   $��1��5p   )   $
��0,10q�5q   )   ���#DDD$��0,0,1,0q�5s   )     LiveCharts.Wpf.PieChart  5t   &   $��1��5u   )   $��0,0,15,0q�5v   )      InnerRadius$ 15Q�5w   )   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5x   )      Series 5y   )   �� *SeriesColection+   ChartLegend 5z   *   "  LiveCharts.Wpf.DefaultLegend  5{   .      
BulletSize$ 10Q�6@      DataTooltip 5}   *   #	  LiveCharts.Wpf.DefaultTooltip	  5~   .    	  
BulletSize$ 10Q�6A   5�   '   �� 5�   &   $��2��63   ��6C   �� *
SeriesList+��5�   *   �� 5�   .   .R�5�   2   $� $ 
Horizontal=�6I   5�   /   ��5�   *   �� 5�   .   .R�5�   2   � $
��15,0q�5�   5   $��Center=�5�   5   $��Center=�5�   5    5�   6   �� 5�   :   �� 5�   :    5�   6   �� 5�   :   $��25��6H   �� 5�   :   $��25��6H   .+�5�   6   �� $��Center=�6@   ��6[   �� *
SeriesName+�� 5�   6   $��1��5�   9   $��Center=�5�   9   ��5�   9   �� *CurrentValue+�� 5�   6   $��1��5�   9   $��10,0,0,0q�5�   9   $��Center=�5�   9   ��5�   9   �� *	IsGrowing+ �� 	Converter# [ ��5�   9   �� *	IsGrowing+# [  �� 5�   6   $��1��5�   9   $��1��5�   9   $��10,0,0,0q�5�   9   $��Center=�5�   9   ��5�   9   �� *	IsGrowing+# [ ��5�   9   �� *
ChangeRate+  �� StringFormat$
  {0}%��5�   3   5�   /   5�   '   5�   #   5�      5�      !   SkeletonTemplate! 5�      �� 5�      .R�5�      � $	��0,8q�6#   " � Triggers" 5�   "   :� 5�   &   # :� RoutedEvent$# Loaded��63   .[�5�   *   �� .��5�   .   �� .��5�   2   �� $ g� AutoReverse$ . % g� RepeatBehavior$% Forever��5�   5   & �� 
TargetName$& imgBlock��5�   5   ' �� TargetProperty$*' $(Background).(SolidColorBrush.Color)�5�   5   	( �� To$( #F7F9FAX�5�   5   ) g� Duration$) 0:0:1D�5�   5   W� 5�   2   $ . $% Forever��5�   5   $& border1��5�   5   $(' "Background.GradientStops[1].Offset�5�   5   	* W� To$* 1X�5�   5   $) 0:0:1.5D�5�   5   W� 5�   2   $ . $% Forever��5�   5   $& border2��5�   5   $(' "Background.GradientStops[1].Offset�5�   5   $* 1X�5�   5   $) 0:0:2D�5�   5   W� 5�   2   $ . $% Forever��5�   5   $& border3��5�   5   $(' "Background.GradientStops[1].Offset�5�   5   $* 1X�5�   5   $) 0:0:1.3D�5�   5   5�   /   5�   +   5�   '    5�   "   �� 5�   &   $	��160 �67   �� 5�   &   .+�5�   "   �� $��imgBlock��5�   %   $��0��5�   %   $��90��5�   %   $��80��5�   %   ���#DDD$ 10��5�   %   �� 5�   "   $��1��6-   $��Center=�6=   .+�5�   &   �� $ border1��5�   )   $	��250��5�   )   $��20��5�   )   $	��0,6q�5�   )   $
��Left=�5�   )   ��5�   *   �� 5�   .   + �� 
StartPoint$+ 0,0.5&�6B   , �� EndPoint$, 1,0.5&�6U   .��5�   2   � - � Offset$- 0Q�6?   . � Color$
. #DDD��6J   � 5�   2   $- 0Q�6?   $. #F7F9FA��6J   � 5�   2   $- 1Q�6?   $
. #DDD��6J   5�   /   5�   '   �� 5�   &   $��border2��5�   )   $��20��5�   )   $	��0,6q�5�   )   ��5�   *   �� 5�   .   $+ 0,0.5&�6B   $, 1,0.5&�6U   .��5�   2   � $- 0Q�6?   $
. #DDD��6J   � 5�   2   $- 0Q�6?   $. #F7F9FA��6J   � 5�   2   $- 1Q�6?   $
. #DDD��6J   5�   /   5�   '   �� 5�   &   $��border3��5   )   $	��400��5  )   $��20��5  )   $	��0,6q�5  )   $
��Left=�5  )   ��5  *   �� 5  .   $+ 0,0.5&�6B   $, 1,0.5&�6U   .��5  2   � $- 0Q�6?   $
. #DDD��6J   � 5  2   $- 0Q�6?   $. #F7F9FA��6J   � 5	  2   $- 1Q�6?   $
. #DDD��6J   5
  /   5  '   5  #   5     5     5     5     5     5     