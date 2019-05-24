# How to select base class in LESS

## Why it's important feature?

When you have a layout with different layers and all layers should have the same background color. It's much much easier for you to set global background color for a whole Page instead of duplicate your code in each element. For this scenario we have `^` selector:

| **Selector** | **Example**    | **Description** |
| ------------ | -------------- | --------------- |
| `^base`      | `^contentpage` | Selects all elements with `ContentPage` as the base class, including `ContentPage` itself. Note that this selector is case insensitive and isn't part of the CSS specification. |

## Could we use it in LESS? 🐛

Without any cheating - no. It will compile `^contentPage {..}` into `^ contentPage {...}` and it's will throw runtime exception.

## Is any possibility to cheat in this case? ✨

Yes, we could cheat with variables at LESS. 

1. Define `@base: ^;` variable at your shared file, which you import everywhere.

##### _For example we have it at `Colors.less` because we load it in each less file._

2. Evaluate this variable like prefix of your base element: `@{base}contentPage {...}`.

💥 And that's it, now it will compiled in proper CSS: `^contentPage {...}`

## I'm using MvxContentPage from MvvmCross and `^mvxContentPage {...}`  does not work for me. What should I do with it?

This problem is similar to the problem with `Span` elements in CSS. However, custom controls like `CustomButton` could we accessible though `cusomButton` element selector, it will not work for custom pages controls(like `MvxContentPage`).

`MvxContentPage` will be accessible at runtime as `ContentPage` so you could just write:
```css
@{base}contentPage {
    background-color: @ModernBackground;
}
```
And it will work properly 😉