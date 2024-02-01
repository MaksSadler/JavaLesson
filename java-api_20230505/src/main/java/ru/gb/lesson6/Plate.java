package ru.gb.lesson6;

public class Plate {

    private int food;


    public Plate(int food) {
        if (food < 0) {
            throw new IllegalArgumentException("food must be positive");
        }
        this.food = food;
    }

    public int increaseFood(int food) {
        if (food <=0) {
            throw new IllegalArgumentException("food is empty");
        }
        if (this.food > food) {
            this.food -= food;
        }
        return food;
    }

    public int decreaseFood(int food) { //нужно уменьшить всё чего хватает
        if (this.food >= food) {
            this.food -= food;
            return food;
        }
        return food;
    }

    @Override
    public String toString() {
        return "(" + food + ")";
    }
}
