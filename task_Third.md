In Java, access modifiers for an interface are allowed.
An interface can be declared as public or have the default package-private access. However, specifying private or protected access for an interface is not allowed.

For example:

```java
public interface MyInterface {
// Interface members (methods, constants)
}
```

However, for interface members (methods and constants), there are some restrictions:

Interface methods are implicitly public and abstract. In other words, specifying the private, protected, or package-private access modifier for interface methods is not allowed.But after Java 9, it's possible to have private methods in interfaces.

```java
public interface MyInterface {
  // public and abstract implicitly
  void myMethod();

  // Allowed since Java 9
  private void privateMethod() {
    // implementation
  }
}
```

In summary, you can use access modifiers with interfaces, but there are some limitations on interface methods and constants.
