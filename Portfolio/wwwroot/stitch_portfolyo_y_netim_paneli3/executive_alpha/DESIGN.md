---
name: Executive Alpha
colors:
  surface: '#f8f9fb'
  surface-dim: '#d9dadc'
  surface-bright: '#f8f9fb'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f3f4f6'
  surface-container: '#edeef0'
  surface-container-high: '#e7e8ea'
  surface-container-highest: '#e1e2e4'
  on-surface: '#191c1e'
  on-surface-variant: '#424754'
  inverse-surface: '#2e3132'
  inverse-on-surface: '#f0f1f3'
  outline: '#727785'
  outline-variant: '#c2c6d6'
  surface-tint: '#005ac2'
  primary: '#0058be'
  on-primary: '#ffffff'
  primary-container: '#2170e4'
  on-primary-container: '#fefcff'
  inverse-primary: '#adc6ff'
  secondary: '#565e74'
  on-secondary: '#ffffff'
  secondary-container: '#dae2fd'
  on-secondary-container: '#5c647a'
  tertiary: '#006947'
  on-tertiary: '#ffffff'
  tertiary-container: '#00855b'
  on-tertiary-container: '#f5fff6'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#d8e2ff'
  primary-fixed-dim: '#adc6ff'
  on-primary-fixed: '#001a42'
  on-primary-fixed-variant: '#004395'
  secondary-fixed: '#dae2fd'
  secondary-fixed-dim: '#bec6e0'
  on-secondary-fixed: '#131b2e'
  on-secondary-fixed-variant: '#3f465c'
  tertiary-fixed: '#6ffbbe'
  tertiary-fixed-dim: '#4edea3'
  on-tertiary-fixed: '#002113'
  on-tertiary-fixed-variant: '#005236'
  background: '#f8f9fb'
  on-background: '#191c1e'
  surface-variant: '#e1e2e4'
typography:
  headline-xl:
    fontFamily: Inter
    fontSize: 36px
    fontWeight: '700'
    lineHeight: 44px
    letterSpacing: -0.02em
  headline-lg:
    fontFamily: Inter
    fontSize: 24px
    fontWeight: '600'
    lineHeight: 32px
    letterSpacing: -0.01em
  headline-md:
    fontFamily: Inter
    fontSize: 20px
    fontWeight: '600'
    lineHeight: 28px
  body-lg:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: 24px
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
  label-md:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '600'
    lineHeight: 16px
    letterSpacing: 0.05em
  mono-data:
    fontFamily: JetBrains Mono
    fontSize: 14px
    fontWeight: '500'
    lineHeight: 20px
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  container-max: 1440px
  sidebar-width: 260px
  gutter: 24px
  margin-page: 32px
  stack-sm: 8px
  stack-md: 16px
  stack-lg: 24px
---

## Brand & Style
The design system is engineered for high-stakes portfolio management, where clarity, precision, and institutional trust are paramount. The brand personality is **Professional, Analytical, and Decisive**. It targets financial analysts and fund managers who require a tool that feels like a high-performance instrument rather than a consumer app.

The visual style is **Modern Corporate Minimalism**. It utilizes high-contrast interfaces to ensure data density remains readable. The aesthetic avoids unnecessary ornamentation, focusing instead on structural hierarchy, functional color application, and a sophisticated interplay between a deep, authoritative sidebar and an airy, expansive content workspace.

## Colors
The color strategy employs a "Focus and Foundation" model.
- **Primary Blue (#3B82F6):** Reserved exclusively for interactive elements, primary actions, and active navigation states.
- **Deep Slate Sidebar (#0F172A):** Provides a grounding vertical anchor. This high-contrast zone separates global navigation from contextual data.
- **Content Background (#F3F4F6):** A soft, neutral canvas that reduces eye strain during long sessions and allows white cards to "pop" effectively.
- **Success/Tertiary (#10B981):** A standard green for positive financial trends and "Buy" signals.
- **Neutral Scale:** Uses Slate/Gray scales for secondary text and borders to maintain a crisp, professional look.

## Typography
This design system utilizes **Inter** for its exceptional legibility in data-heavy environments. 
- **Hierarchy:** Use `headline-lg` for dashboard section titles and `body-md` for standard table row data.
- **Utility:** For financial figures, percentages, and tickers, use a medium weight to ensure the numbers are the most prominent part of the UI.
- **Capitalization:** Use `label-md` with all-caps for table headers and small metadata tags to differentiate them from actionable data.
- **Mobile:** Scale `headline-xl` down to 28px for mobile views to prevent excessive wrapping.

## Layout & Spacing
The layout follows a **Fixed-Fluid Hybrid** model. The sidebar remains fixed at 260px, while the main content area fluidly expands to a maximum of 1440px to ensure data charts don't become overly stretched on ultra-wide monitors.

- **Grid:** A 12-column system is used within the content area for card layouts (e.g., 3-column stats row, 8-column main chart + 4-column side list).
- **Rhythm:** An 8px base unit drives all spacing. 
- **Breakpoints:**
  - **Desktop (1024px+):** Full sidebar, 32px page margins.
  - **Tablet (768px - 1023px):** Icon-only collapsed sidebar, 24px page margins.
  - **Mobile (<767px):** Bottom navigation or hamburger menu, 16px page margins, cards stack vertically.

## Elevation & Depth
Depth in this design system is primarily created through **Tonal Separation** rather than heavy shadows.

- **Layer 0 (Background):** The `#F3F4F6` gray foundation.
- **Layer 1 (Cards/Surface):** Pure white (`#FFFFFF`) surfaces. These use a subtle 1px border (`#E2E8F0`) instead of a shadow to maintain a clean, "flat-plus" aesthetic.
- **Layer 2 (Overlays):** Modals and dropdowns use a soft, large ambient shadow (15% opacity, 20px blur) to indicate they are floating above the workspace.
- **Active States:** Subtle inner shadows or 2px solid borders are used to denote focused input fields or selected card states.

## Shapes
The shape language is **Balanced and Approachable**. 
- **Standard Elements:** Buttons, input fields, and small tags use a `0.5rem` (8px) radius.
- **Large Elements:** Primary dashboard cards and containers use a `rounded-lg` or `rounded-xl` (12px to 16px) radius to soften the high-contrast data presentation.
- **Iconography:** Use "Linear" or "Outline" icons with a 2px stroke width to match the clean aesthetic of the typography.

## Components
- **Buttons:** Primary buttons are solid `#3B82F6` with white text. Secondary buttons are ghost-style with a slate border.
- **Cards:** White background, 16px corner radius, 24px internal padding. Every card should have a clear `headline-md` title.
- **Inputs:** Clean white backgrounds with a 1px `#CBD5E1` border that transitions to primary blue on focus. 
- **Data Tables:** Borderless rows with a subtle `#F8FAFC` hover state. Header text uses the `label-md` style.
- **Status Chips:** Small, rounded-pill shapes with low-opacity background fills (e.g., 10% green background with 100% green text) for status indicators like "Active," "Pending," or "Risk."
- **Sidebar Items:** High-contrast white text/icons against the deep slate background. Active items receive a vertical blue "indicator bar" on the left edge.