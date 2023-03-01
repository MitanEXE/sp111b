#include <stdio.h>

double integrate(double (*f)(double),double a, double b) {
    double sum=0.0;
    for (double x=a; x<b; x+=0.001){
        sum += f(x)*0.001;
    }
    return sum;
}

double square(double x) {
    return x*x;
}

int main() {
    printf("integrate(square, 0.0, 2.0)=%f\n", integrate(square, 0.0, 2.0));
}
