# API de Registro de Pessoas com MongoDB
## Desenvolvido por Henrique Mariano

##### Iniciar o Aplicativo
Para iniciar o aplicativo deve-se ter o [Visual Studio](https://visualstudio.microsoft.com/pt-br/) instalado. Abrindo o aplicativo pelo Visual Studio clique no botão Play escrito IIS Express. Necessita do [MongoDB](https://www.mongodb.com/) instalado na máquina também. O aplicativo iniciará com a página Exibir Registro.

##### Exibir Registros
Nesta página podemos ver todos os registros salvos no banco de dados, junto com o ID que ele associa ao dado, em uma tabela. Nota-se que Telefone e Endereço não possuem os dados mas sim botões, estes botões nos levam para uma outra tabela com os Telefones e Endereços registrados para aquela pessoa. Em qualquer uma das tabelas podemos clicar no botão Alterar no final da linha para alterar qualquer dado daquela pessoa. No fim da linha também temos o botão Deletar para apagar os dados daquela informação.

##### Incluir Registro
A tela de Incluir Registro possui um formulário para prenchimento de dados de pessoas a serem inseridas no banco de dados. Os dados a serem inseridos são:
- Nome
- Data de Nascimento
- Telefone (Máximo de 5 telefones por pessoa)
- Endereço (Máximo de 5 endereços por pessoa)
- CPF
- RG
- Redes Sociais:
     - Facebook
     - Linkedin
     - Twitter
     - Instagram

Ao clicar no botão incluir, todos os dados serão incluidos no banco de dados e o usuário será redirecionado para a página Exibir Registros.

##### Banco de Dados
Esta aplicação utiliza-se do banco de dados [MongoDB](https://www.mongodb.com/) para armazenamento de dados. A aplicação tentará armazenar os dados em um database com o nome de "D1" e uma collection com o nome de "Registros", caso não haja um ou mais dos requisitos ele criará os requisitos faltantes, seja ele o database ou a collection. 
Ele utiliza a string de conexão "mongodb://localhost:27017". Caso haja a necessidade de alterar alguma destas informações deve-se utilizar o arquivo appsettings.json. Para alterar o nome da collection utiliza-se o arquivo MongoDbConstext.cs linha 38.

##### Considerações Finais
Caso haja alguma dúvida, deseja uma mudança ou encontre algum problema com o aplicativo entre em contato com o desenvolvedor.

Aplicação de uso livre. Dê os devidos créditos.

##### Contato
Email para contato com o desenvolvedor: rique.m@hotmail.com

©2022
