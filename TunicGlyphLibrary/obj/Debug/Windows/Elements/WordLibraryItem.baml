   M S B A M L   `   `   `  ����L  HTunicGlyphLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TunicGlyphLibrary.Windows.Elements"TunicGlyphLibrary.Windows.Elements  5      8    2TunicGlyphLibrary.Windows.Elements.WordLibraryItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:TunicGlyphLibrary.Windows.Elements     5      
������ $��65��5
      $	��100��5      .��5      � -   5        $��Frame��5      
������   � ColumnDefinitions  5   
   �� 5      �� 5      $��2* �6   .+�5   
   �� $��0��6   $��2��6$   ��5      �� 5       �� ImageSource$* $../../Resources/LibraryItemFrame.png��6    j� Stretch$ Uniform=�6P   6d   5      (� 5   
   $��0��6   $��
0, 5, 0, 8q�6"   .��5      <   6TunicGlyphLibrary.Windows.Elements.LanguageWordControl  -   5          Name$ WordDisplay��5   (   $��5q�6=      KeyboardEditingEnabled .     MouseEditingEnabled .     GlyphInactiveBrush
 ����  K� ZIndex$ 1��6�   $��Center=�6�   $��Center=�6�   5      �� 5   
   -   5        $��DefinitionTextBlock��5      $��1��6/    �� TextAlignment$
 Left=�6@   $��Center=�6U   ��5      *�5      -)pack://application:,,,/Fonts/#Espressonal)�5      5!      � 5#   
   -   5        $��ControlPanel��5#      $��1��6#   $y�Hidden=�63   $��Right=�6G   .+�5$      �� $��1��6   $��
0, 4, 0, 8q�6$   $.��(../../Resources/LibraryItemSidePanel.png��68   $��Uniform=�6j   $��Right=�6|   6�   �� 5%      $��1��6   	 �� Orientation$	 
Horizontal=�6)   $��Center=�6B   .+�5&      9   3TunicGlyphLibrary.Windows.Elements.StyledMiniButton  -   5        
  Name$
 EditBtn��5&   )   9   3TunicGlyphLibrary.Windows.Elements.StyledMiniButton   Click$ EditBtn_OnClick��6�      IconUri$" ../../Resources/editIcon.png?�6:   $��
5, 0, 0, 0q�6a   $��Center=�6u   6�     5'      -   5        $
 	DeleteBtn��5'   )   $ DeleteBtn_OnClick��6�   $ ../../Resources/Cross.png?�6<   $��
5, 0, 5, 0q�6`   $��Center=�6t   6�   5(      5)      5*      5+      