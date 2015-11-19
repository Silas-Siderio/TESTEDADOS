# TESTEDADOS

1 - Considerações sobre o teste .

Tecnologías utilizadas  -   sql server 2014 , visual studio 2015 , framework 4.6

2 - Instruções sobre  o  funcionamento da aplicação .

  a . no subdiretório "SCRIPTBANCO"  do projeto , existe  o script para gerar a base de dados , execute-o.
  b . no arquivo web config do projeto , favor modificar a string de conexão ,  com as credenciais do seu ambiente de base de dados.
  c . no subdiretório "UploaderFolder" , onde o arquivo será postado ,   existe uma cópia do arquivo dadoss.txt com  a proposta de arquivo para carga pela aplicação.
  d . criar a aplicação no seu server IIS com o conteúdo do diretório TAXWEB_TESTE.
  e .  Verificar se o pool de aplicação do IIS onde a aplicação reside está habilitada para o framework 4.6.
  f - executar a aplicação.
