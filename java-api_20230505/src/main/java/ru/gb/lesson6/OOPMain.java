package ru.gb.lesson6;

import java.util.HashSet;

public class OOPMain {

    public static void main(String[] args) {
        Cat murzik = new Cat("Murzik", 100,50);
        Plate plate = new Plate(25);

        murzik.eat(plate);
        //murzik.eat(plate);

        System.out.println(murzik);
        System.out.println(plate);
//
//
//        Cat first = new Cat("Name", 150,30);
//        Cat second = new Cat("Name", 100,30);
//
//        System.out.println(first == second); // false
//        System.out.println(first.equals(second));
//
//        System.out.println(first.hashCode());
//        System.out.println(second.hashCode());
//
//        HashSet<Cat> cats = new HashSet<>();
//        cats.add(first);
//        cats.add(second);
//        System.out.println(cats);

    }

}