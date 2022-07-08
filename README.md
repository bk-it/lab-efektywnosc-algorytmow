# Efektywność algorytmów - eksperyment

## Podstawowe informacje

Program badający efektywność 3 algorytmów sortowania: 
* InsertionSort (https://www.geeksforgeeks.org/insertion-sort/)
* MergeSort (https://www.geeksforgeeks.org/merge-sort/)
* QuickSortClassical klasyczny (https://www.geeksforgeeks.org/quick-sort)
* QuickSort (Array.Sort())

## Próbki danych

Liczby w tablicy są losowe i rozmieszczone:
* random - losowo
* sorted - posortowane rosnąco
* reversed - posortowane malejąco
* almost sorted - posortowane rosnąco z niewielkim procentem zaburzonych wartości
* few unique - niewiele wartości unikalnych w tablicy

## Sposób pomiaru

1. stwórz stoper
2. wygeneruj odpowiednią tablicę testową
3. sklonuj tablicę
4. włącz stoper
5. wykonaj sortowanie
6. wyłącz stoper i zapisz wynik
7. wykonaj 10 razy kroki 3-6
8. oblicz średni czas i odchylenie standardowe
