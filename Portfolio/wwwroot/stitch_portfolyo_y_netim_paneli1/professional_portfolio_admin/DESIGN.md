---
name: Professional Portfolio Admin
colors:
  surface: '#f7f9fb'
  surface-dim: '#d8dadc'
  surface-bright: '#f7f9fb'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f2f4f6'
  surface-container: '#eceef0'
  surface-container-high: '#e6e8ea'
  surface-container-highest: '#e0e3e5'
  on-surface: '#191c1e'
  on-surface-variant: '#434655'
  inverse-surface: '#2d3133'
  inverse-on-surface: '#eff1f3'
  outline: '#737686'
  outline-variant: '#c3c6d7'
  surface-tint: '#0053db'
  primary: '#004ac6'
  on-primary: '#ffffff'
  primary-container: '#2563eb'
  on-primary-container: '#eeefff'
  inverse-primary: '#b4c5ff'
  secondary: '#565e74'
  on-secondary: '#ffffff'
  secondary-container: '#dae2fd'
  on-secondary-container: '#5c647a'
  tertiary: '#46566c'
  on-tertiary: '#ffffff'
  tertiary-container: '#5e6e85'
  on-tertiary-container: '#e9f0ff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#dbe1ff'
  primary-fixed-dim: '#b4c5ff'
  on-primary-fixed: '#00174b'
  on-primary-fixed-variant: '#003ea8'
  secondary-fixed: '#dae2fd'
  secondary-fixed-dim: '#bec6e0'
  on-secondary-fixed: '#131b2e'
  on-secondary-fixed-variant: '#3f465c'
  tertiary-fixed: '#d3e4fe'
  tertiary-fixed-dim: '#b7c8e1'
  on-tertiary-fixed: '#0b1c30'
  on-tertiary-fixed-variant: '#38485d'
  background: '#f7f9fb'
  on-background: '#191c1e'
  surface-variant: '#e0e3e5'
typography:
  headline-xl:
    fontFamily: Inter
    fontSize: 30px
    fontWeight: '700'
    lineHeight: 38px
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
  headline-lg-mobile:
    fontFamily: Inter
    fontSize: 20px
    fontWeight: '600'
    lineHeight: 28px
rounded:
  sm: 0.125rem
  DEFAULT: 0.25rem
  md: 0.375rem
  lg: 0.5rem
  xl: 0.75rem
  full: 9999px
spacing:
  sidebar-width: 260px
  header-height: 64px
  container-padding: 2rem
  gutter: 1.5rem
  stack-sm: 0.5rem
  stack-md: 1rem
  stack-lg: 2rem
---

## Brand & Style
The design system is engineered for a high-performance, professional admin environment. It adopts a **Corporate / Modern** aesthetic, prioritizing utility, clarity, and architectural order. The brand personality is efficient and trustworthy, designed to feel like a high-end SaaS platform. 

The visual narrative relies on a clear distinction between navigation and workspace. A deep, authoritative sidebar provides a grounding "frame" for the user, while the primary content area uses generous whitespace to reduce cognitive load during data management and content editing tasks.

## Colors
This design system utilizes a high-contrast layout to separate global navigation from the functional workspace.

- **Primary (#2563EB):** A vibrant "Action Blue" used for high-priority interactions, active states, and call-to-action buttons.
- **Secondary (#0F172A):** A deep slate/dark navy reserved for the sidebar and global navigation backgrounds to provide a sense of structure and depth.
- **Neutral (#F8FAFC):** A clean, cool-toned white/gray for the main workspace background to maximize legibility and minimize eye strain.
- **Surface Tints:** Use `#E2E8F0` for borders and `#94A3B8` for secondary text and disabled states.

## Typography
**Inter** is the foundation of the design system, chosen for its exceptional legibility in data-heavy environments. 

- **Scale:** Headings use a slight negative letter spacing to feel tighter and more modern. 
- **Hierarchy:** Labels for table headers and small metadata use a semi-bold weight and uppercase styling to distinguish them from editable body content. 
- **Readability:** Body text is optimized at 14px for standard UI elements and 16px for long-form content editing.

## Layout & Spacing
The layout follows a **Fixed-Fluid hybrid model**. The sidebar remains fixed at `260px`, while the main workspace scales fluently to the viewport width.

- **Grid:** A 12-column grid is used for dashboard widgets, with common spans of 3, 4, 6, and 12 columns.
- **Responsive Behavior:** 
  - **Desktop (>1024px):** Full sidebar visible.
  - **Tablet (768px - 1023px):** Sidebar collapses to an icon-only "rail" (72px) or hides behind a hamburger menu.
  - **Mobile (<767px):** Single column layout, container padding reduces to `1rem`, and the sidebar is purely off-canvas.

## Elevation & Depth
This design system uses **Tonal Layers** and **Ambient Shadows** to define hierarchy.

1.  **Level 0 (Base):** The main background (`#F8FAFC`), entirely flat.
2.  **Level 1 (Cards/Tables):** White surfaces with a 1px border in `#E2E8F0`. Use a very soft shadow: `0px 1px 3px rgba(0,0,0,0.05)`.
3.  **Level 2 (Dropdowns/Popovers):** Elevated white surfaces with a more pronounced shadow: `0px 10px 15px -3px rgba(0,0,0,0.1)`.
4.  **Level 3 (Modals):** Centered surfaces with a scrim background (40% opacity slate) to focus the user's attention.

The sidebar does not use shadows; it relies on its dark color value to create depth against the light workspace.

## Shapes
The shape language is **Soft** and disciplined. 

- **Standard Elements:** Buttons, input fields, and small cards use a `0.25rem` (4px) radius to maintain a professional, sharp appearance.
- **Large Components:** Dashboard widgets and main content containers use a `0.5rem` (8px) radius to soften the overall interface.
- **Interactive States:** Focus rings should follow the border radius of the parent element with a 2px offset.

## Components
- **Buttons:** Primary buttons are solid Blue `#2563EB` with white text. Secondary buttons use a white background with a Slate `#E2E8F0` border.
- **Sidebar Items:** Hover states should use a subtle highlight (Slate at 10% opacity). The active state features a 3px primary blue vertical line on the left edge.
- **Data Tables:** Row-based layout with `1px` bottom borders. Header cells use `label-md` typography. Zebra striping is avoided; use hover highlights for row tracking.
- **Input Fields:** Default state has a `1px` gray border. On focus, the border changes to Primary Blue with a subtle 2px blue glow (glow opacity 15%).
- **Dashboard Widgets:** Card-based containers with a standard header (Title + Action menu) and consistent internal padding of `1.5rem`.
- **Status Chips:** Small, pill-shaped indicators for "Draft," "Published," or "Pending" using low-saturation background tints (e.g., light green background with dark green text).