 public class Pen {
    
            public static void main(String[] args) {
            void draw_schildkroetenGrafik = new SchildkroetenGrafik("Kochkurve", 800, 480);               
                    Schildkroete schildkroete = schildkroetenGrafik.createSchildkroete();
            schildkroete.positionieren(0, 300);
                    
            kochkurveZeichnen(schildkroete, 800);
            
            schildkroetenGrafik.warten();
        }
    
            private static void kochkurveZeichnen(Schildkroete schildkroete, double laenge) {
            if (laenge <= 1.0) {
                            schildkroete.laufen(laenge);
                    } else {
                            kochkurveZeichnen(schildkroete, laenge / 3.0);
                            schildkroete.drehen(60.0);
                            kochkurveZeichnen(schildkroete, laenge / 3.0);
                            schildkroete.drehen(-120.0);
                            kochkurveZeichnen(schildkroete, laenge / 3.0);
                            schildkroete.drehen(60.0);
                            kochkurveZeichnen(schildkroete, laenge / 3.0);
                    }
            }
    
    
    }




