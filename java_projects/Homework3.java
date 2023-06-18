import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;

public class Homework3 {

    /**
     * Пусть дан произвольный список целых чисел.
     *
     * 1) Нужно удалить из него чётные числа (void removeEven(ArrayList<Integer>
     * list))
     * 2) Найти минимальное значение (Integer findMin(ArrayList<Integer> list))
     * 3) Найти максимальное значение
     * 4) Найти среднее значение
     *
     * То есть, нужно реализовать 4 метода, каждый из которых принимает список целых
     * чисел, и делает свою работу.
     */

    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<>(
                Arrays.asList(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        removeEven(list);
        findMin(list);
        findmax(list);
        average(list);
    }

    // Задача1.
    private static void removeEven(ArrayList<Integer> list) {
        for (Iterator<Integer> iterator = list.iterator(); iterator.hasNext();) {
            Integer number = iterator.next();
            if (number % 2 == 0) {
                iterator.remove();
            }
        }
        System.out.println(list);
    }

    // Задача2.
    private static void findMin(ArrayList<Integer> list) {
        int min = list.get(0);
        for (int num : list) {
            if (num < min) {
                min = num;
            }
        }
        System.out.println("Минимальное значение равно: " + min);
    }

    // Задача3.
    private static void findmax(ArrayList<Integer> list) {
        int max = list.get(0);
        for (int num : list) {
            if (num > max) {
                max = num;
            }
        }
        System.out.println("Максимальное значение равно: " + max);
    }

    // Задача4.
    private static void average(ArrayList<Integer> list) {
        int sum = 0;
        for (int x : list) {
            sum += x;
        }
        System.out.print("Среднее арифметическое равно: " + sum / list.size());
    }
}
