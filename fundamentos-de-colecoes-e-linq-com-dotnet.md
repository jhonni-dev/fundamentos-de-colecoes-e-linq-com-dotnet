# Fundamentos de Coleções e LINQ com .NET

## Aula 1
### Arrays
+ O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo
  + **Exemplos:**
  + int[] arrays = new int[4]
  + int[] array = new int[] {42,75,74,61};
  + string[] nomes = {"Jan","Fev"};
+ **Índice:** é a posção de um determinado valor de um array, sempre começando com zero
+ O array pode possuir mais de uma dimensão:
  + int[,] array = new int[4,2];
  + 4 é o número de linhas
  + 2 é o número de colunas
+ Se tentar passarum tipo diferente do definido na inicialização do array, o intelisense acusará um erro
  + É possível converter o tipo com o .Parse()
  + Não é possível modificar em tempo de execução o tamanho do array, mas é possível criar um array maior passando os elementos do antigo para um novo
  + Se tentar acessar um elemento que não exite, o intelisense não acusará o erro mas o compilador sim.
  + Para percorrer um array sem exceder o seu limite, é recomendado usar o .length
+ **Array Multidimensional:** é um array composto de linhas e colunas, também conhecido como matriz

## Aula 2
### Manipulando Arrays
+ **Ordenando Arrays:** Para ordenar um array, existem diversos algoritmos de ordenação e diferentes técnicas e casos a serem considerados.
+ **Bubble sort:** 
