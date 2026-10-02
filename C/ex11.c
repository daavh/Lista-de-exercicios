#include <stdio.h>

int main(void) {
    double salario, bonus, total;
    printf("Salario base (ex.: 1500.00): ");
    scanf("%lf", &salario);
    printf("Bonus em porcentagem: ");
    scanf("%lf", &bonus);

    if (salario < 0 || bonus < 0) {
        printf("Valores invalidos.\n");
        return 0;
    }

    total = salario + salario * bonus / 100;
    printf("Salario final: R$ %.2f\n", total);
    return 0;
}
