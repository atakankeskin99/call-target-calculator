import java.util.Scanner;

public class CallTargetCalculator {

    private static final int DAILY_TARGET_CALLS = 200;
    private static final double DAILY_NET_HOURS = 8.5;

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Bugün kaç saat login oldun? (örn: 10): ");
        double loginHours = readPositiveDouble(sc);

        System.out.print("Toplam mola kaç dakika? (örn: 90): ");
        double breakMinutes = readNonNegativeDouble(sc);

        System.out.print("Şu ana kadar kaç çağrı aldın? (örn: 109): ");
        int callsTaken = readNonNegativeInt(sc);

        // Şu ana kadar net çalışılan süre
        double netWorkedHours = loginHours - (breakMinutes / 60.0);
        if (netWorkedHours < 0) netWorkedHours = 0;

        // Günün kalan net çalışma süresi
        double remainingNetHours = DAILY_NET_HOURS - netWorkedHours;
        if (remainingNetHours < 0) remainingNetHours = 0;

        // Kalan çağrı
        int remainingCalls = DAILY_TARGET_CALLS - callsTaken;

        System.out.println("\n--- Özet ---");
        System.out.printf("Günlük net süre (sabit): %.2f saat%n", DAILY_NET_HOURS);
        System.out.printf("Şu ana kadar net çalışma: %.2f saat%n", netWorkedHours);
        System.out.printf("Kalan net süre: %.2f saat%n", remainingNetHours);
        System.out.printf("Günlük hedef çağrı: %d%n", DAILY_TARGET_CALLS);
        System.out.printf("Alınan çağrı: %d%n", callsTaken);

        if (remainingCalls <= 0) {
            System.out.printf("Kalan çağrı: 0 (Hedefi %d çağrı aştın)%n", Math.abs(remainingCalls));
            System.out.println("Bundan sonrası bonus 😄");
            sc.close();
            return;
        }

        System.out.printf("Kalan çağrı: %d%n", remainingCalls);

        if (remainingNetHours == 0) {
            System.out.println("Kalan net süre 0 görünüyor. (8.5 saati doldurmuşsun ya da girdilerde sorun var)");
            System.out.println("Bu durumda 'saatte kaç çağrı' hesaplanamaz.");
            sc.close();
            return;
        }

        double requiredCallsPerHour = remainingCalls / remainingNetHours;

        System.out.printf("Bundan sonra hedefi tutturmak için gereken tempo: %.2f çağrı/saat%n",
                requiredCallsPerHour);

        sc.close();
    }

    private static double readPositiveDouble(Scanner sc) {
        while (true) {
            if (sc.hasNextDouble()) {
                double v = sc.nextDouble();
                if (v > 0) return v;
            } else {
                sc.next();
            }
            System.out.print("Geçerli bir pozitif sayı gir: ");
        }
    }

    private static double readNonNegativeDouble(Scanner sc) {
        while (true) {
            if (sc.hasNextDouble()) {
                double v = sc.nextDouble();
                if (v >= 0) return v;
            } else {
                sc.next();
            }
            System.out.print("Geçerli bir sayı gir (0 veya daha büyük): ");
        }
    }

    private static int readNonNegativeInt(Scanner sc) {
        while (true) {
            if (sc.hasNextInt()) {
                int v = sc.nextInt();
                if (v >= 0) return v;
            } else {
                sc.next();
            }
            System.out.print("Geçerli bir tamsayı gir (0 veya daha büyük): ");
        }
    }
}
