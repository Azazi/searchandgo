   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5   <    SearchAndGo   SearchAndGo.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      oMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     6<   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�     �� 	Resources  5         ComboBoxFocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  ButtonNormalBackground �� EndPoint �� 
StartPoint � Color � Offset  ButtonNormalBorder	 �� Color  DownArrowGeometry   ComboBoxReadonlyToggleButton
 �� 
TargetType �� 
TargetType+   %Microsoft.Windows.Themes.ButtonChrome  Name J� IsMouseOver   RenderMouseOver   RenderPressed   RoundCorners F�Name �� Triggers P� Property P� Value �� 
TargetName  TextBoxBorder � MappingMode  ComboBoxEditableTextBox ��Name  ComboBoxToggleButton   BorderBrush   
Background  ComboBoxEditableTemplate �Name � ColumnDefinitions �Name � AllowsTransparency �� RelativeSource5   /Microsoft.Windows.Themes.SystemDropShadowChrome  Name    Color! �� MaxDropDownHeight" �� ElementName# ��Name$ �� ClearTypeHint% ��Name& ��Name-  'System.Windows.Input.KeyboardNavigation'   DirectionalNavigation,   &Microsoft.Windows.Themes.ListBoxChrome(  Name)   BorderBrush*   BorderThickness+   
Background,   RenderMouseOver- J� IsKeyboardFocusWithin.   RenderFocused/ ��Name0 �� 
IsReadOnly1 d� 	IsChecked2 �� Mode3 P� 
SourceName 	 v4 �� SelectionBoxItemTemplate5 �� SelectionBoxItem#6 �� SelectionBoxItemStringFormat7 �� ContentStringFormat8 J� IsHitTestVisible9 �� Triggers 
 
HelpButton'  !System.Windows.VisualStateManager:   VisualStateGroups%  System.Windows.VisualStateGroup;   Transitions%  System.Windows.VisualTransition<   GeneratedDuration=   States   System.Windows.VisualState>   
Storyboard? �� TargetProperty@ �� 
TargetName9	  3System.Windows.Media.Animation.EasingDoubleKeyFrameA O� KeyTimeB O� ValueC ��NameD � CursorE � ToolTipF J� OpacityMaskG �� ImageSourceH J� Effect-
  'System.Windows.Media.Effects.BlurEffect��%�%  &	        &	 �     &	 �    &	 �    &	 �    7  &	 �    &	 �    &	 �    7  &	 �
    7  7  &		 4    7   7  7  7  7  7  &	
 ,    �� 5      .�5      ��  � �� 5	      �� 5
      .R�5      �� $��4,4,21,4q�6    . #��� ��6?   $��1��6�   $	 1 2R�6�   5      5      5      �� 5      $	 0,1&�67   $	 0,0&�6F   .��5      � $ #F3F3F3��6   $ 0Q�6"   � 5      $ #EBEBEB��6   $	 0.5Q�6"   � 5      $ #DDDDDD��6   $	 0.5Q�6"   � 5      $ #CDCDCD��6   $ 1Q�6"   5      �� 5      $	 	#FF707070��6/   �5      M 0 0 L 3.5 4 L 7 0 Z�6>   �� 5      "
 d�6/   .�5      ��  �@�OverridesDefaultStyle . 6-   �� 5       � �� .  6!   �� 5       � |� .  6!   �� 5       �@��	ClickMode$ Press=�6!   �� 5       � �� 5      �� 5      " d�6   .R�5         $ Chrome��6.   # z 6>   # z��6n    .  .  ._�5!   	   � $��Right=�6   #��� r�6*   .+�5"   
   F� $ Arrow��6   8��  
���   �$��Center=�6U   $��3,1,0,0q�6r   $��Center=�6�   5#   
   5$   	    5%      P� 5&   	    �@d�	IsChecked$
 trueY�6&   . �5'   
   �� $ Chrome��6*    �@ RenderPressed . 6>   5(   
   P� 5)   	    � {� .  . �5*   
   �� $ Arrow��6!    � �� �#AFAFAF64   5+   
   5-      5/      50      �� 51      $
 0,20&�6.   $ Absolute=�6>   $	 0,0&�6U   .��52      � $ #ABADB3��6   $
 0.05Q�6"   � 53      $ #E2E3EA��6   $
 0.07Q�6"   � 54      $ #E3E9EF��6   $ 1Q�6"   55      �� 56      "
 ��6*   .�57      ��  �@�OverridesDefaultStyle . 6-   �� 58       �@J�	AllowDrop . 6!   �� 59       � ��$ 0��6    �� 5:       � ��$ 0��6!   �� 5;       �@�FocusVisualStyle 6(   Z� �� 5<       �@��PanningMode$ VerticalFirst=�60   �� 5=       �@��IsFlicksEnabled .  6.   �� 5>       � �� 5?      �� 5@      " ��6   .R�5A      �� $ PART_ContentHost��6   
������ |�.  $��Hidden=�6Z   $��Hidden=�6�   5B      5D      5E      �� 5F      "
 d�6'   .�5G      ��  �@�OverridesDefaultStyle . 6-   �� 5H       � �� .  6!   �� 5I       � |� .  6!   �� 5J       �@��	ClickMode$ Press=�6!   �� 5K       � �� 5L      �� 5M      " d�6   .R�5N        $ Chrome��6.   # z��6>   # z��6j   # z 6�   # z��6�    .   . #��� r�6   ._�5O   	   F� $ Arrow��6   8��  
���   �$��Center=�6T   $��0,1,0,0q�6q   $��Center=�6�   5P   	    5Q      P� 5R   	    �@d�	IsChecked$
 trueY�6&   . �5S   
   �� $ Chrome��6*    �@ RenderPressed . 6>   5T   
   P� 5U   	    � {� .  . �5V   
   �� $ Arrow��6!    � �� �#AFAFAF64   5W   
   5Y      5[      5\      �� 5]      " ��65   .R�5^      � $ 	Placement��6
    .  5_      �� 5`      $��* �6   �� 5a      $
��Auto �6   .+�5c      � $ 
PART_Popup��6    . $��2��6:   #��� .�6�   $��Bottom=�6�   ��6N   �� *IsDropDownOpen+ �� *TemplatedParent+.��5d        $
 Shdw��67   $  Transparent��6E   #��z! 6Y   ��6�   �� *ActualWidth+$" 	Placement��._�5e      �� $# DropDownBorder��6   #��� ��6'   $��1q�6s   #��� ��6�   ._�5f   	   �� $ DropDownScrollViewer��6   .��5g   
   � $$ Enabled=�6   .+�5h      �� $
��Left=�6   $��0��6-   $	��Top=�68   $��0��6P   .+�5i      �� $% 
OpaqueRect��6   ��6*   �� *
Background+$" DropDownBorder����6b   �� *ActualHeight+$" DropDownBorder����6�   �� *ActualWidth+$" DropDownBorder��5j      �� 5k      $& ItemsPresenter��6   $' 	Contained=�62   # z 6g   5l      5m   
   5n   	   5o      5p        5q      $( Border��6-   #) z��6=   #* z��6i   #+ z��6�   $��2��6�   #, z 6�   #. z- 6  �� 5r      $/ PART_EditableTextBox��6   #��z��6,   #��z��6�   8��  #��z��6  0 6v   �� *
IsReadOnly+ �� *TemplatedParent+6  d� 5s      $��1��6   8�� 1 6#   �� *IsDropDownOpen+$2 TwoWay=� �� *TemplatedParent+6�   5t       5u      P� 5v       �@J�IsKeyboardFocusWithin . . �5w      ��  � ��
 �   �6$   5x      P� 5y       �@��IsDropDownOpen . . �5z      �� $ Border��6'    �@ RenderFocused . 6;   5{      P� 5|       �@��HasItems .  . �5}      �� $ DropDownBorder��6     � ��$ 95��6<   5~      P� 5       � {� .  . �5�      �� # � ��6$    � ���� 5�       � �� �	#FFF4F4F46$   5�      P� 5�       �@��
IsGrouping . . �5�      ��  � �� .  67   5�      P� 5�      $3 
PART_Popup��6'    �@�HasDropShadow . . �5�      �� $
 Shdw��6     � ��$ 0,0,5,5q�62   �� 5�      $
 Shdw��6    �@ Color$ 	#71000000��61   5�      P� 5�      $3 DropDownScrollViewer��67    � �� .  . �5�      �� $ 
OpaqueRect��6$    6<   �� *VerticalOffset+$" DropDownScrollViewer�� �@��Top�� 5�      $ 
OpaqueRect��6%    6=   �� *HorizontalOffset+$" DropDownScrollViewer�� �@��Left5�      5�      �� 5�      "
 ��6   .�5�      ��  �@�FocusVisualStyle8   6(   �� 5�       � ��# � ��6"   �� 5�       � ��8  6"   �� 5�       � ��8  6#   �� 5�       � ��$ 1q�6'   �� 5�       � ��$
 Auto=�6B   �� 5�       � ��$
 Auto=�6@   �� 5�       � ��$	 4,3q�6   �� 5�       � �� . 65   �� 5�       �@��PanningMode$
 Both=�60   �� 5�       �@��IsFlicksEnabled .  6.   �� 5�       � �� 5�      �� 5�      " ��6   .R�5�      � $ MainGrid��6    .  5�   	   �� 5�   
   $��* �6   �� 5�   
   #��� r�6   $��0 �6n   .+�5�   	   � $ 
PART_Popup��6    . $��2��6=   $��1q�6�   #��� .�6�   $��Bottom=�6  ��6Q   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�   
     $
 Shdw��6:   $  Transparent��6H   #��z! 6\   ��6�   �� *ActualWidth+$" MainGrid��._�5�      �� $# DropDownBorder��6   #��� ��6*   $��1q�6v   #��� ��6�   ._�5�      �� $ DropDownScrollViewer��6   .��5�      � $$ Enabled=�6   .+�5�      �� $
��Left=�6   $��0��60   $	��Top=�6;   $��0��6S   .+�5�      �� $% 
OpaqueRect��6   ��6-   �� *
Background+$" DropDownBorder����6e   �� *ActualHeight+$" DropDownBorder����6�   �� *ActualWidth+$" DropDownBorder��5�      �� 5�      $& ItemsPresenter��6   $' 	Contained=�65   # z 6j   5�      5�      5�      5�      5�   
   d� 5�   	   $��2��6   8�� ���	#FFB63B3B1 6*   �� *IsDropDownOpen+$2 TwoWay=� �� *TemplatedParent+6�   �� 5�   	   #��z4 6   #��z��6W   #��z5 6�   #7 z6 6�   #��z��6
  8 .  #��z��6f  # z 6�  #��z��6�  5�   	    5�      P� 5�   	   $3 
PART_Popup��6*    �@�HasDropShadow . . �5�   
   �� $
 Shdw��6#    � ��$ 0,0,5,5q�65   �� 5�   
   $
 Shdw��6"    �@ Color$ 	#71000000��64   5�   
   P� 5�   	    �@��HasItems .  . �5�   
   �� $ DropDownBorder��6#    � ��$ 95��6?   5�   
   P� 5�   	    � {� .  . �5�   
   �� # � ��6'    � ���� 5�   
    � �� �	#FFF4F4F46'   5�   
   P� 5�   	    �@��
IsGrouping . . �5�   
   ��  � �� .  6:   5�   
   P� 5�   	   $3 DropDownScrollViewer��6:    � �� .  . �5�   
   �� $ 
OpaqueRect��6'    6?   �� *VerticalOffset+$" DropDownScrollViewer�� �@��Top�� 5�   
   $ 
OpaqueRect��6(    6@   �� *HorizontalOffset+$" DropDownScrollViewer�� �@��Left5�   
   5�      5�      9 5�      P� 5�       �@��
IsEditable . . �5�      ��  � ��8  6%   �� 5�       � ��# � ��6$   �� 5�       � �� .  6#   �� 5�       � ��$ 3q�6!   �� 5�       � ��8  6"   5�      5�      �� 5�      "
 ��6   .�5�      ��  � �� 5�      �� 5�      " ��6   .R�5�      � : 5�   	     5�   
   CommonStates��; 5�        5�      $< 0:0:0.5D�6   .= 5�        
Normal��6     5�      	MouseOver��.> 5�      �� .��5�      U� $? (UIElement.Opacity)�6+   $@ image��6[   .\�5�      	  $A 0��6#   $B 0.495Q�6/   5�      U� 5�      $? (UIElement.Opacity)�6+   $@ image1��6[   .\�5�      	  $A 0��6#   $	B 0.5Q�6/   5�      5�      5�        5�      Pressed��.> 5�      �� .��5�      U� $? (UIElement.Opacity)�6+   $@ image1��6[   .\�5�      	  $A 0��6#   $B 0.695Q�6/   5�      5�      5�        5�      Disabled��6   5�      .+�5�   	   �� $C image��6#   $y�Hidden=�6   $)��#Resources\Images\SportCheckLogo.gif��62   $
��Fill=�6_   $
D Hand��6n   $
E Home��6|   F 5�   
   �� 5�      $'G !Resources/Images/french_flag.jpeg��6   5�   
   �� 5�   	   #��z��6   ��. # z 6x   #��z��6�   $
D Hand��6�   $��FR��6  F 6  Z� H 5�   
   
  5�      5�   
   �� 5�   	   $C image1��6   $��french_flag.jpeg��6   $
��Fill=�69   �� 5   	   $��FR��6   $��Stretch=�6   $��Stretch=�6:   $��52.49,40.813,52.29,40.812q�6V   5  	    5     P� 5  	    �@J�	IsFocused . 6&   P� 5  	    �@��IsDefaulted . 6(   P� 5  	    �@J�IsMouseOver . 6(   P� 5  	    � �� . 6&   P� 5  	    � {� .  6&   5	     5     5     5     5     