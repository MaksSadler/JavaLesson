public class Homework2 {
    public static void main(String[] args) {
        /**
         * 1. Реализовать метод isPalindrome
         * 2. Пересмотреть мой спич про работу с файловой системой. Подготовить вопросы.
         */

        /**
         * Проверить, является ли строка палиндромом.
         * Палиндром - это строка, которая читается одинаково слева и справа
         * abcdedcba -> true
         * a -> true
         * abc -> false
         * abcd -> false
         * abba -> true
         */
        String word = "abba";
        System.out.println(isPalindrome(word));
    }

    static boolean isPalindrome(String source) {
        int a = source.length();// TODO: 08.06.2023
        for (int i = 0; i < (a / 2); ++i) {
            if (source.charAt(i) != source.charAt(a - i - 1)) {
                return false;
            }
        }
        return true;
    }
}
