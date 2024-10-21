class LC1342 {
    public static int numberOfSteps(int num) {
        int steps = 0;
        while(num>0){
            steps++;
            if(num%2 == 1)
                num--;
            else
                num /= 2;
        }
        return steps;
    }

    public static void main(String[] args){
        System.out.println(numberOfSteps(14));
        System.out.println(numberOfSteps(8));
        System.out.println(numberOfSteps(123));
    }
}