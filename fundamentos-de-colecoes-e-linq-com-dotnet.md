# Fundamentos de Coleções e LINQ com .NET

## Aula 1
### Arrays
+ O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo. 
+ Por padrão, um array tem seus elementos do tipo int com valor 0
  + **Exemplos:**
  + int[] arrays = new int[4]
  + int[] array = new int[] {42,75,74,61};
  + string[] nomes = {"Jan","Fev"};
+ **Índice:** é a posção de um determinado valor de um array, sempre começando com zero
+ O array pode possuir mais de uma dimensão:
  + int[,] array = new int[4,2];
  + 4 é o número de linhas
  + 2 é o número de colunas
+ Se tentar passar um tipo diferente do definido na inicialização do array, o intelisense acusará um erro
  + É possível converter o tipo com o .Parse()
  + Não é possível modificar em tempo de execução o tamanho do array, mas é possível criar um array maior passando os elementos do antigo para um novo
  + Se tentar acessar um elemento que não exite, o intelisense não acusará o erro mas o compilador sim.
  + Para percorrer um array sem exceder o seu limite, é recomendado usar o .length
+ **Array Multidimensional:** é um array composto de linhas e colunas, também conhecido como matriz

## Aula 2
### Manipulando Arrays
+ **Ordenando Arrays:** Para ordenar um array, existem diversos algoritmos de ordenação e diferentes técnicas e casos a serem considerados.
+ **Bubble sort:** faz a comparação se um elemento é maior que seu sucessor e caso seja verdadeiro armazena este valor em uma variável e troca de posição com este.
+ **Classe Array:** é uma classe do C# que nos oferece diversos métodos para auxiliar na manipulação destes arrays
  + **Array.Sort():** Organiza um array em ordem crescente
  + **Array.Copy(origem, destino, array.length:** copia um array em parte ou totalmente(array.length)
  + **Array.Exisits():** procura por um determinado elemento dentro do array. É possível também buscar por valores através de comparações (>,<,>=,<=,==,!=). Usa predicate como segundo parâmetro (elemento => elemento >= valor)
  + **Array.TrueForAll():** testa uma condição para todos os elementos de um array e retorna true ou false. Usa predicate como segundo parâmetro (elemento => elemento > valor)
  + **Array.Find:** encontra um valor e retorna a primeira ocorrência
  + **Array.FindAll:** retorna uma coleção de valores através de outro array com as condições de busca definidas por você
  + **Array.FindIndex:** retorna a posição que o array se encontra e utiliza um predicate como parâmetro
  + **Array.FindLast:** retorna a última ocorrência do valor que se está buscando
  + **Array.IndexOf:** recebe diretamente o valor e vai sempre procurar por uma condição de igualdade
  + **Array.Resize:** redimensiona a capacidade do array
  + **Array.ConvertAll:** converte um tipo de array para outro através de um predicate

## Aula 3
### Coleções Genéricas
+ No C# existem classes de coleções que agrupam valores e essas classes são padronizadas para as operações mais comuns, como:
  + Ordenação
  + Obter valor por índice
  + Obter valor com expressões
  + Trabalhar com tamanhos dinâmicos
+ Você pode criar uma coleção genérica usando uma das classes no namespace **System.Collections.Generic**. Uma coleção genérica é útil quando cada item na coleção tem o mesmo tipo de dados. Uma coleção gnérica impõe tipagem forte, permitindo que apenas o tipo de dados desejado seja adicionado.
+ Para declarar uma lista usa-se **List\<T>** onde T representa o tipo de dados que queremos (a barra não faz parte do comando).
  + Exemplo: List\<strin> estados = new List\<string>(); (as barras não fazem parte)
+ Para adicionar um elemento na lista basta inserir o nome da lista.**Add()**;
+ **.Count:** retorna o número de elementos da lista
+ Para percorrer os elementos da lista usa-se o **foreach** ou **for**
+ **Remover itens**
+ Quando removemos um item de uma lista, esta automaticamente reorganiza os itens e redimensiona o array
  + **Remove():** para remover um único elemento na lista e retorna um booleano informando se deu certo ou não
  + **RemoveAll():** passa um predicate para o método para que ele possa remover um ou mais elementos
  + **RemoveAt():** remove um elemento baseado no seu índice
  + **RemoveRange():** remove elementos baseado no index de acordo com o range informado
+ **Adicionar coleções na lista**
+ **.AddRange():** adiciona elementos entre coleções do mesmo tipo. A coleção adicionada sera colocada no final da coleção de destino
+ **.Insert():** O primeiro parâmetro é o índice que será ocupado e o segundo parâmetro é o elementro a ser inserido

## Aula 4
### Coleções Específicas
+ As coleções específicas implementam regras para sua ordem de acesso e manipulação de seus elementos. São elas:
  + **Queue (Fila):**  obedece a ordem FIFO, portanto não é possível inserir ou remover elementos através de um índice
  + Para percorrer a fila e ler os elementos utiliza-se o *while*
    + **Queue\<T>:** onde T é o tipo de dado que irá compor a fila. É possível definir os elementos da fila em sua inicialização
      + Exemplo: Queue\<string> fila = new Queue\<string> fila()
    + **.Enqueue():** adiciona elemento a fila
    + **.Dequeue():** remove e retorna o objeto atual no começo de sua fila
    + **.Peek():** retorna o objeto do começo de sua fila sem removê-lo
    + **.Count():** retorna a quantidade de elementos presentes na fila
  + **Stack (Pilha):** obedece a ordem LIFO, portanto não é possível inserir ou remover elementos através de um índice
    + **Stack\<T>:** onde T é o tipo de dado que irá compor a pilha. É possível definir os elementos da pilha em sua inicialização
    + **.Push():** insere elementos no topo da pilha
    + **.Pop():** remove elemento do topo da pilha
    + **.Peek():** retorna o último objeto da pilha sem removê-lo
    + **.Count():** retorna a quantidade de elementos presentes na pilha

## Aula 5
### Dicionários
+ Um dicionário é uma coleção de chave e valor, permitindo que vocÊ recupere rapidamente seus itens baseado em sua chave
+ O dicionário armazena a sua chave em hash
+ Não é possível existir chaves repetidas, entretanto é possível duplicar valores
+ Se tentar acessar uma chave que não existe, o programa retorna um erro e interrompe a execução
+ Exemplo de um dicionário:
  + Dictionary<string,string> estados = new Dicitionary<string,string>();
+ **.Add():** adiciona um par chave, valor do tipo indicado na criação do dicionário
+ Para **percorrer** um dicionário usa-se o _foreach(KeyValuePair<>item in colection)_
  + **item.Key:** para acessar a chave
  + **item.Value:** para acessar o valor
+ Para **acessar** um valor é preciso passar a chave com o nome do dicionário: 
  + string valorProcurado = "BA";
  + Console.WriteLine(estados[valorProcurado]);
+ Para **atualizar** um valor basta passarmos um sinal de = após inserir a chave a ser atualizada
  + Exemplo: estados[valorProcurado] = "BA - Teste de atualização"
+ Para **remover** um valor utiliza-se o método .Remove passando a chave que se quer remover
+ Para **acessar um valor de maneira segura** utiliza-se o método .TryGetValue que obtém o valor desejado e diz se conseguiu obter o valor ou não

## Aula 6
### LINQ
+ O Language-Integrated Query (LINQ) é uma maneira de você utilizar uma sintaxe de consulta padronizada para coleções de objetos
+ Na prática, é uma maneira de fazer operações nas coleções de uma maneira padronizada utilizando as cláusulas mais comuns
+ O LINQ pode ser integrado a qualquer coleção, como array, lista, data source...
+ É possível utilizar o LINQ através de **QUerry Syntax** ou **Method Syyntax**
+ Obter o menor elemento: **.Min()**
+ Obter o maior elemento: **.Max()**
+ Obter a média dos valores: **.Average()**
+ **SOMA:** .Sum()
+ **Distinct (elementos únicos sem repetição):** .Distinct().ToArray();
