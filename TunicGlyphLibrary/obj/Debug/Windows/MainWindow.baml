   M S B A M L   `   `   `  ����L  HTunicGlyphLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TunicGlyphLibrary.Windows.Elements"TunicGlyphLibrary.Windows.Elements  5   	   U/clr-namespace:TunicGlyphLibrary.Windows.Editors!TunicGlyphLibrary.Windows.Editors  5   	   *    $TunicGlyphLibrary.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Eelements0clr-namespace:TunicGlyphLibrary.Windows.Elements     5   	   Ceditors/clr-namespace:TunicGlyphLibrary.Windows.Editors     5   	   -   5          � AllowsTransparency  . 
������  � Title$ 
MainWindow��5   	   $	��700��6   $	��950��6)    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      ��  �� CornerRadius$ 8��6   
������ $��1q�68   ._�5   
   � ��5   
   �� 5       �� ImageSource$5 /pack://application:,,,/Resources/background.png��6    j� Stretch$
 Fill=�6W    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��0��5      $��2��6$   $	��Top=�68   $��15��6P   
������ 6o   �� 5   
   -   5        $��0��5      $��2��6$   $��Bottom=�68   $��15��6S   
������ 6r   �� 5   
   -   5        $��0��5      $
��Left=�6$   $��12��6?   
������ 6]   �� 5   
   -   5        $��1��5      	 K� ZIndex$		 100��6$   $��Right=�67   $��25��6S   
������ 6q   �� 5!   
   $		 100��6   $��1��6(   
 �� Orientation$
 
Horizontal=�68   $	��Top=�6Q   $��Right=�6i   .+�5"      9   3TunicGlyphLibrary.Windows.Elements.StyledMiniButton  -   5          Name$ MinimizeBtn��5"   (   9   3TunicGlyphLibrary.Windows.Elements.StyledMiniButton   Click$ MinimizeBtn_OnClick��6o   $��5q�6=      IconUri$" ../../Resources/LineIcon.png?�6H   6o     5#      -   5        $ CloseBtn��5#   (   $ CloseBtn_OnClick��6i   $��5q�6:   $ ../../Resources/Cross.png?�6E   6i   5$      �� 5&   
   $��1��6   $��0, 37.5, 0, 37q�6    $��Right=�68   $��Center=�6T   $(��"../../Resources/SideDecoration.png��6o   6�   � 5(   
   $��0��6   $��28, 31, 10, 35q�6   .+�5)      9   3TunicGlyphLibrary.Windows.Editors.WordEditorControl  -   5          Name$ 
WordEditor��5)   (   $��0��6<   6N   5*      ;   5TunicGlyphLibrary.Windows.Elements.WordLibraryDisplay  5+   
   -	   5          Name$ WordLibraryList��5+   =   $��5, 35, 85, 40q�6&   $��1��6V   6h   � 5-   
   -
   5        $��LoadingLayer��5-      $��2��6#   $��0��67   $��Stretch=�6G   $��Stretch=�6e   .+�5.      �� 
���   � J� Opacity$
 0.95Q�6%   �� 5/      $��../../Resources/Panel.png��6   $	��300��67   $	��150��6C   �� 50      $��Center=�6   $��Center=�65   $��Loading Data from Disk...��6P   ���#4b3d44$��20(�51   -   ��52      *�53      -)pack://application:,,,/Fonts/#Espressonal)�55      57      58      5:      5;      5<      