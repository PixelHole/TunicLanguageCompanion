   M S B A M L   `   `   `  ����L  HTunicGlyphLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TunicGlyphLibrary.Windows.Elements"TunicGlyphLibrary.Windows.Elements  5      9    3TunicGlyphLibrary.Windows.Editors.WordEditorControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Eelements0clr-namespace:TunicGlyphLibrary.Windows.Elements     5      
������ .��5
      �   � RowDefinitions  5   
   �� 5      $��6* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   � -   5        .+�5      � 
������ $��
0,0 ,0 ,10q�6,   $��0��6@    � ColumnDefinitions 5      �� 5      �� 5      $��8* �6'   �� 5      .+�5      <   6TunicGlyphLibrary.Windows.Elements.LanguageWordControl  -   5          Name$ WordDisplay��5   /   $��1��6D   6W   >   8TunicGlyphLibrary.Windows.Elements.GlyphCountMinusButton  5      -   5          Name$ RemoveGlyphBtn��5   1   >   8TunicGlyphLibrary.Windows.Elements.GlyphCountMinusButton   Click$ RemoveGlyphBtn_OnClick��6Y   $��0��6I   6z   =   7TunicGlyphLibrary.Windows.Elements.GlyphCountPlusButton  5      -   5          Name$ AddGlyphBtn��5   0   =   7TunicGlyphLibrary.Windows.Elements.GlyphCountPlusButton   Click$ AddGlyphBtn_OnClick��6U   $��2��6E   6s   5      �� 5      -   5        $��WordDisplayUtility��5      $y�Hidden=�63    �� Orientation$ 
Horizontal=�6G   $��Right=�6`   $	��Top=�6|   .+�5      9   3TunicGlyphLibrary.Windows.Elements.StyledMiniButton  -   5          Name$ GlyphClearBtn��5   ,   9   3TunicGlyphLibrary.Windows.Elements.StyledMiniButton	   Click$	 GlyphClearBtn_OnClick��6r   
   IconUri$
 ../../Resources/Cross.png?�6C   $��5q�6g   6r     5       -   5        $ GlyphSearchBtn��5    ,   $	 GlyphSearchBtn_OnClick��6x   $$
 ../../Resources/SearchIcon.png?�6D   $��5q�6m   $y�	Collapsed=�5!   ,   5"      5#      � 5$   
   -   5        $��
0, 6, 0, 0q�5$      $��1��6#   
������ .+�5%      A   ;TunicGlyphLibrary.Windows.Elements.DefinitionsEditorControl  -	   5          Name$ DefinitionsEditor��5%   0   6M   �� 5&      -
   5        $��DefPanelUtility��5&      $y�Hidden=�60    K� ZIndex$ 20��6D   $ 
Horizontal=�6V   $��Right=�6o   $	��Top=�6�   .+�5'        -   5        $ DefinitionClearBtn��5'   ,   $ 	 DefinitionClearBtn_OnClick��6w   $
 ../../Resources/Cross.png?�6H   $��5q�6l   6w     5(      -   5        $ DefinitionSearchBtn��5(   ,   $!	 DefinitionSearchBtn_OnClick��6~   $$
 ../../Resources/SearchIcon.png?�6I   $��5q�6s   $y�	Collapsed=�5)   ,   5*      5+      �� 5,   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5-      5	   /TunicGlyphLibrary.Windows.Elements.StyledButton	  -   5         	 Name$ DoneBtn��5-   $   5
   /TunicGlyphLibrary.Windows.Elements.StyledButton 
  Click$ SaveToLibraryBtn_OnClick��6X   $��5q�65   $	��160��6@    	  Text$
 Done��6L   6X   	  5.      -   5        $ 	CancelBtn��5.   $   $ CancelBtn_OnClick��6s   $��5q�67   $	��160��6B   $ Cancel��6N   $y�	Collapsed=�6\   6s   5/      50      51      