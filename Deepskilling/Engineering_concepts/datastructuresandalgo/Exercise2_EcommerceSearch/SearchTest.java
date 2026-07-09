public class SearchTest {

    public static void main(String[] args) {

        Product[] products = {

                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Phone", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")

        };

        Product linearResult =
                SearchOperations.linearSearch(products, "Shoes");

        if (linearResult != null) {

            System.out.println("Linear Search Found");

            System.out.println("ID : " + linearResult.productId);

            System.out.println("Name : " + linearResult.productName);

        }

        Product binaryResult =
                SearchOperations.binarySearch(products, "Shoes");

        if (binaryResult != null) {

            System.out.println();

            System.out.println("Binary Search Found");

            System.out.println("ID : " + binaryResult.productId);

            System.out.println("Name : " + binaryResult.productName);

        }

    }
}