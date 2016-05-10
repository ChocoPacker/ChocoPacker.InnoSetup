# ChocoPacker.InnoSetup
Library dedicated to processing the InnoSetup executables.

# InnoSetup magics

```
{
	{ { 'r', 'D', 'l', 'P', 't', 'S', '0', '2', 0x87, 'e', 'V', 'x' },    INNO_VERSION(1, 2, 10) },
	{ { 'r', 'D', 'l', 'P', 't', 'S', '0', '4', 0x87, 'e', 'V', 'x' },    INNO_VERSION(4, 0,  0) },
	{ { 'r', 'D', 'l', 'P', 't', 'S', '0', '5', 0x87, 'e', 'V', 'x' },    INNO_VERSION(4, 0,  3) },
	{ { 'r', 'D', 'l', 'P', 't', 'S', '0', '6', 0x87, 'e', 'V', 'x' },    INNO_VERSION(4, 0, 10) },
	{ { 'r', 'D', 'l', 'P', 't', 'S', '0', '7', 0x87, 'e', 'V', 'x' },    INNO_VERSION(4, 1,  6) },
	{ { 'r', 'D', 'l', 'P', 't', 'S', 0xcd, 0xe6, 0xd7, '{', 0x0b, '*' }, INNO_VERSION(5, 1,  5) },
};
```

# InnoSetup offsets

```
SetupLoaderHeaderOffset = 0x30;
SetupLoaderHeaderMagic = 0x6f6e6e49;
```
