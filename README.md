# MPeak-Player-WinForm
- Este é um Player de Música que contruí utilizando o Framework gráfico WindowsForm do .NET. Esse projeto está incompleto, porém, implementei as principais funções\n
adicionar as músicas a serem tocadas pelo player, controles de play, pause, next e prev e exibição da capa da música no player. Fique a vontade para Terminar de implementar\n
o restante das funções. 

## Objetivo
- Este projeto tem como objetivo estudar o Windows Form e o C# como geral. Utilizar recursos como bibliotecas diversas como manipuladores de audio, de imagem,\n
componentes visuais customizáveis etc. Trabalhar e explorar os Eventos no Windows Form, comunicação entre 'Controls' e aplicar os conhecimentos estudados sobre C# e\n
algumas boas práticas (apesar de eu ainda estar estudando sobre isso rsrs ). Mas, esse projeto pode ser usado como inspiração para você perceber o que dá pra fazer\n
com o desenvolvimento Desktop usando a linguagem de programação C#.

## Bibliotecas Utilizadas

### 1. [Naudio](https://www.nuget.org/packages/NAudio)
A biblioteca NAudio é uma biblioteca de código aberto para processamento de áudio em aplicativos .NET, incluindo aplicativos Windows Forms. Ela permite gravar, \n
reproduzir, editar e converter arquivos de áudio em formatos populares, como MP3, WAV e WMA.

Com a NAudio, é possível criar aplicativos que envolvem processamento de áudio em tempo real, como softwares de gravação de áudio, aplicativos de edição de áudio e\n
aplicativos de análise de áudio. A biblioteca fornece suporte para várias funcionalidades, como gravação e reprodução em tempo real, mixagem de áudio, aplicação de\n
efeitos de áudio, detecção de nível de áudio e muito mais.

### 2. [FontAwesome.Sharp](https://www.nuget.org/packages/FontAwesome.Sharp)
A biblioteca FontAwesome é muito útil para desenvolvedores de aplicativos Windows Forms que desejam adicionar ícones escaláveis e de alta qualidade aos seus \n
aplicativos sem a necessidade de criar imagens separadas para cada tamanho de ícone. Isso ajuda a economizar tempo de desenvolvimento e garante que os ícones em\n
seus aplicativos sejam consistentes em todos os tamanhos e resoluções de tela. Os ícones podem ser adicionados aos controles do Windows Forms, como botões, menus,\n
barras de ferramentas e muito mais.

### 3. [TagLibSharp](https://www.nuget.org/packages/TagLibSharp)
A biblioteca TagLibSharp é uma biblioteca de código aberto que permite manipular metadados de arquivos de áudio, incluindo informações sobre o artista, álbum,\n
título da música, gênero, data de lançamento e muito mais. Ela pode ser usada em aplicativos .NET, incluindo aplicativos Windows Forms.

### 4. Windows Media Player
O Windows Media Player é uma biblioteca padrão do Windows que permite reproduzir arquivos de áudio e vídeo em aplicativos Windows Forms. Ele é um reprodutor\n
multimídia completo que suporta vários formatos de áudio e vídeo, incluindo MP3, WAV, AVI, WMV e muito mais. Ao incorporar o Windows Media Player em aplicativos\n
Windows Forms, os desenvolvedores podem criar interfaces personalizadas de reprodutores de mídia, permitindo que os usuários reproduzam e controlem a\n
reprodução de arquivos de áudio e vídeo diretamente de seus aplicativos.

Para adicionar o componente Windows Media Player no Windows Form, siga os seguintes passos:\n
- Abra o Visual Studio e crie um novo projeto Windows Forms.
- Abra a caixa de ferramentas (Toolbox) no Visual Studio e localize o controle Windows Media Player. Se ele não estiver visível,\n
clique com o botão direito do mouse na caixa de ferramentas e selecione "Choose Items" (Escolher itens). Na janela "Choose Toolbox Items",\n
selecione a guia ".NET Framework Components" e encontre o controle "Windows Media Player" na lista. Selecione-o e clique em "OK" para adicioná-lo\n
à caixa de ferramentas.
- Arraste e solte o controle Windows Media Player na janela do formulário (form) do seu projeto.

## Dependências de Projeto
- .NET Framework 4.8
- Sistema Operacional Windows

## Como Executar o Projeto
- Clone o repositório: git clone https://github.com/seu-usuario/seu-repositorio.git
- Instale as dependências via Nuget
- Execute o projeto: npm start

## Contribuindo
- Faça um fork do repositório
- Crie sua feature branch: git checkout -b minha-nova-feature
- Commit suas mudanças: git commit -am 'Adiciona nova feature'
- Push para a branch: git push origin minha-nova-feature
- Abra um Pull Request
