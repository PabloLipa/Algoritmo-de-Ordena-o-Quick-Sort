# Algoritmo-de-Ordenação-Quick-Sort


Passo a Passo do Quicksort

# 1 Inicialização:

O método Main chama Preenchervetor() para preencher o vetor com os valores fornecidos e, em seguida, chama QuicksortA(vetto, 0, vetto.Length - 1) para iniciar a ordenação.

# 2 Primeira chamada de QuicksortA:

Parâmetros: vetor = [3, 6, 4, 9, 19, 4, 1, 0, 8, 10], inicio = 0, finaldovetor = 9

Pivô p é o valor do meio do vetor: p = vetor[(0 + 9) / 2] = vetor[4] = 19

# 3 Particionamento:

Inicializa esq = 0 e dir = 9

Compara e troca elementos:

vetor[dir] > p (10 > 19), dir--

vetor[dir] > p (8 > 19), dir--

vetor[dir] > p (0 > 19) é falso, vetor[esq] < p (3 < 19), esq++

vetor[esq] < p (6 < 19), esq++

Continua comparando e incrementando/decrementando esq e dir até que esq seja maior ou igual a dir

Troca vetor[esq] e vetor[dir], repetindo até que esq cruze com dir

# 4 Recursão:

Após a primeira iteração, o vetor é particionado em dois sub-vetores:

[3, 6, 4, 9, 8, 4, 1, 0, 10, 19]

Chama QuicksortA recursivamente para os sub-vetores.

# 5 Passos Finais:

Repetir os passos de particionamento e recursão até que todos os sub-vetores sejam ordenados.

Sub-vetores gerados:

[0, 1, 3, 4, 4, 6, 8, 9, 10, 19]

# como o vetor é ordenado na prática:

Primeira chamada: pivô 19, particiona e não há trocas significativas, sub-vetores: [3, 6, 4, 9, 8, 4, 1, 0, 10] e [19].

Segunda chamada para [3, 6, 4, 9, 8, 4, 1, 0, 10], pivô 8, particiona resultando em sub-vetores: [3, 6, 4, 0, 4, 1, 8], [9], [10].

Continua o particionamento e ordenação recursiva até que todos os elementos estejam ordenados.


# O que é o Quick Sort?

O algoritmo quicksort é um método de ordenação muito rápido e eficiente, inventado por C.A.R. Hoare em 1960 , quando visitou a Universidade de Moscovo como estudante. Naquela época, Hoare trabalhou em um projeto de tradução de máquina para o National Physical Laboratory. Ele criou o quicksort ao tentar traduzir um dicionário de inglês para russo, ordenando as palavras, tendo como objetivo reduzir o problema original em subproblemas que possam ser resolvidos mais fácil e rápido. Foi publicado em 1962 após uma série de refinamentos (Wikipédia).