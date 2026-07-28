---
name: Executive Portfolio Admin
colors:
  surface: '#f8f9ff'
  surface-dim: '#cbdbf5'
  surface-bright: '#f8f9ff'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#eff4ff'
  surface-container: '#e5eeff'
  surface-container-high: '#dce9ff'
  surface-container-highest: '#d3e4fe'
  on-surface: '#0b1c30'
  on-surface-variant: '#464554'
  inverse-surface: '#213145'
  inverse-on-surface: '#eaf1ff'
  outline: '#767586'
  outline-variant: '#c7c4d7'
  surface-tint: '#494bd6'
  primary: '#4648d4'
  on-primary: '#ffffff'
  primary-container: '#6063ee'
  on-primary-container: '#fffbff'
  inverse-primary: '#c0c1ff'
  secondary: '#565e74'
  on-secondary: '#ffffff'
  secondary-container: '#dae2fd'
  on-secondary-container: '#5c647a'
  tertiary: '#595c5e'
  on-tertiary: '#ffffff'
  tertiary-container: '#727577'
  on-tertiary-container: '#fbfdff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#e1e0ff'
  primary-fixed-dim: '#c0c1ff'
  on-primary-fixed: '#07006c'
  on-primary-fixed-variant: '#2f2ebe'
  secondary-fixed: '#dae2fd'
  secondary-fixed-dim: '#bec6e0'
  on-secondary-fixed: '#131b2e'
  on-secondary-fixed-variant: '#3f465c'
  tertiary-fixed: '#e0e3e5'
  tertiary-fixed-dim: '#c4c7c9'
  on-tertiary-fixed: '#191c1e'
  on-tertiary-fixed-variant: '#444749'
  background: '#f8f9ff'
  on-background: '#0b1c30'
  surface-variant: '#d3e4fe'
typography:
  display-sm:
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
  container-max: 1440px
  sidebar-width: 280px
  gutter: 24px
  margin-mobile: 16px
  margin-desktop: 32px
  stack-sm: 8px
  stack-md: 16px
  stack-lg: 24px
---

## Brand & Style
The design system focuses on an **Organized Corporate Modern** aesthetic tailored for high-efficiency content management. The brand personality is professional, authoritative, and precise, ensuring the user feels in total control of their digital presence. 

The style utilizes a "Clean Canvas" approach for the main workspace—prioritizing data clarity and legibility—contrasted against a "Command Center" sidebar that uses deep tones to establish a clear structural hierarchy. White space is used generously but purposefully to group related administrative tasks, reducing cognitive load during long editing sessions.

## Colors
This design system employs a high-contrast functional palette:
- **Primary (Indigo):** Used for primary actions, active navigation states, and focus indicators. It provides a vibrant "hit" of color against the neutral backdrop.
- **Secondary (Deep Navy):** Reserved for the sidebar and global navigation elements to create a grounded, professional frame.
- **Tertiary (Ghost Gray):** Used for the main content background and subtle card headers to differentiate surfaces without using heavy borders.
- **Neutral (Slate):** Applied to body text, icons, and secondary metadata.

Success, Warning, and Error states should follow standard utility conventions (Emerald-500, Amber-500, Rose-500) but maintain the same saturation levels as the primary Indigo.

## Typography
Inter is the sole typeface for the design system, chosen for its exceptional legibility in data-dense environments. 

- **Headlines:** Use tighter letter spacing and semi-bold weights to create a strong visual anchor for page sections.
- **Body:** Standardized at 14px for administrative density, ensuring a large amount of information is visible without scrolling.
- **Labels:** Utilized for table headers and small metadata, using uppercase and increased tracking to differentiate from interactive body text.

## Layout & Spacing
The design system follows a **Fixed-Fluid Hybrid** model. The sidebar remains fixed at 280px, while the main content area occupies the remaining width up to a maximum of 1440px to prevent line lengths from becoming unreadable on ultra-wide monitors.

A strict 8px grid governs all spatial relationships. 
- **Desktop:** 32px outer margins for the main stage, with 24px gutters between dashboard cards.
- **Tablet:** Sidebar collapses to an icon-only rail (72px); margins reduce to 24px.
- **Mobile:** Sidebar becomes a hidden drawer; margins reduce to 16px. All multi-column forms reflow to a single column stack.

## Elevation & Depth
Hierarchy is established through **Tonal Layering** rather than heavy shadows. 

- **Level 0 (Background):** The Tertiary color (#F8FAFC) acts as the canvas.
- **Level 1 (Cards/Surface):** Pure White (#FFFFFF) surfaces with a subtle 1px border (#E2E8F0). This creates a "flat-plus" look that feels modern and crisp.
- **Level 2 (Dropdowns/Modals):** Subtle ambient shadows are used (0px 10px 15px -3px rgba(0,0,0,0.1)) to indicate temporary interaction layers.
- **Active State:** Navigation items in the sidebar use a subtle left-aligned 4px primary color border and a low-opacity Indigo tint on the background.

## Shapes
The design system adopts a **Soft** shape language. 
- **Standard (4px):** Used for input fields, checkboxes, and small utility buttons to maintain a professional, sharp edge.
- **Large (8px):** Applied to data cards and main container surfaces to soften the overall "enterprise" feel.
- **X-Large (12px):** Reserved for featured project thumbnails or empty-state illustrations.

This restrained use of rounded corners ensures the interface feels contemporary without appearing overly casual or "bubbly."

## Components
- **Sidebar Navigation:** Use the Secondary color for the background. Icons should be 20px, stroke-based, with a subtle 60% opacity for inactive states and 100% white for active states.
- **Data Cards:** White background, 8px radius, 1px light gray border. Include a clear "Label-MD" header and "Display-SM" value for key statistics.
- **Tables:** No outer border on table containers. Use a light gray bottom border (1px) for rows. Zebra striping is not required; use hover states to highlight rows instead.
- **Buttons:** 
  - *Primary:* Solid Indigo background, white text.
  - *Secondary:* Ghost gray background, Slate text.
  - *Ghost:* No background, Primary text, used for "Cancel" or low-priority actions.
- **Input Fields:** 1px gray border that transitions to 2px Indigo on focus. Labels should always be visible above the field using "Label-MD" styling.
- **Chips/Badges:** Small, high-radius (pill) shapes with low-opacity background tints of the status color (e.g., light green background with dark green text for "Published").