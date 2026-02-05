// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

namespace Esri.Calcite.WPF;

/// <summary>A collection of Calcite UI Icons.</summary>
/// <remarks>The enum <c>UInt16</c> values correspond to the character code in the Calcite symbol font.</remarks>
public enum CalciteIcon : ushort
{
	/// <summary>1/2x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, playback speed, one half times, slowed down, fraction</remarks>
	/// <release>3.19.9</release>
	OneHalfTimes = 59136,

	/// <summary>1/4x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, playback speed, one fourth times, slowed down, fraction, 25 percent</remarks>
	/// <release>3.19.9</release>
	OneFourthTimes = 59137,

	/// <summary>1/8x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, playback speed, one eighth times, slowed down, fraction</remarks>
	/// <release>3.19.9</release>
	OneEighthTimes = 59138,

	/// <summary>1x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, playback speed, one time, slowed down, speed up</remarks>
	/// <release>3.19.9</release>
	OneTime = 59139,

	/// <summary>2D Explore</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, navigate</remarks>
	/// <release>1.5</release>
	_2DExplore = 59140,

	/// <summary>2x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, two times, speed up, second, double time</remarks>
	/// <release>3.19.9</release>
	TwoTimes = 59141,

	/// <summary>360 View</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.1.0, look, panorama, full view, image, generic, show</remarks>
	/// <release>2.1.0</release>
	_360View = 59142,

	/// <summary>3D Glasses</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, ortho-stereo</remarks>
	/// <release>1.5</release>
	_3DGlasses = 59143,

	/// <summary>4x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, playback speed, four times, speed up</remarks>
	/// <release>3.19.9</release>
	FourTimes = 59144,

	/// <summary>8x</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.9, numbers, playback speed, eight times, speed up</remarks>
	/// <release>3.19.9</release>
	EigthTimes = 59145,

	/// <summary>A Z</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: text, 1.5.0, sort, alphabetical, ascending, descending</remarks>
	/// <release>1.5</release>
	AZ = 59146,

	/// <summary>A Z Down</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text, sort, alphabetical, descending</remarks>
	/// <release>1.5</release>
	AZDown = 59147,

	/// <summary>A Z Up</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text, sort, alphabetical, ascending</remarks>
	/// <release>1.5</release>
	AZUp = 59148,

	/// <summary>Absolute Direction</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.3, gis, arrows, compass, needle, directions, movement, rotate</remarks>
	/// <release>3.25.3</release>
	AbsoluteDirection = 59149,

	/// <summary>Absolute Elevation</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.3, gis, elevate, measure, height, depth, water, sea level, measurements</remarks>
	/// <release>3.25.3</release>
	AbsoluteElevation = 59150,

	/// <summary>Access String Results</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.0.0, code, access string results, text, access text results, text file, dialogue box, attributes, tags, style</remarks>
	/// <release>3.0.0</release>
	AccessStringResults = 59151,

	/// <summary>Accessibility</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.22.7, people, person, disability, disabilities, standing, human, alt text, accessible, inclusion, color blindness, screen reader, inclusive design</remarks>
	/// <release>3.22.7</release>
	Accessibility = 59152,

	/// <summary>Activity Monitor</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, heartbeat, wave, activities, status, health, pulse</remarks>
	/// <release>1.5</release>
	ActivityMonitor = 59153,

	/// <summary>Actual Size</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.16.6, windows, 100%, true scale, true size, 1:1, actual scale, view, no zoom, extent, screen</remarks>
	/// <release>3.16.6</release>
	ActualSize = 59154,

	/// <summary>Add And Update Features</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.4, layers, maps, gis, mapping, location, data, feature layers</remarks>
	/// <release>3.22.4</release>
	AddAndUpdateFeatures = 59155,

	/// <summary>Add Constant</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, raster function template, adding, scalar constant, value, function, input</remarks>
	/// <release>3.25.2</release>
	AddConstant = 59156,

	/// <summary>Add Features</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.4, layers, maps, gis, mapping, location, data, feature layers</remarks>
	/// <release>3.22.4</release>
	AddFeatures = 59157,

	/// <summary>Add In</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.4.0, adding, squares, app, addition</remarks>
	/// <release>2.4.0</release>
	AddIn = 59158,

	/// <summary>Add In Edit</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.4.0, adding, pencil, app, markup</remarks>
	/// <release>2.4.0</release>
	AddInEdit = 59159,

	/// <summary>Add In New</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.4.0, plus, app, adding</remarks>
	/// <release>2.4.0</release>
	AddInNew = 59160,

	/// <summary>Add Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.12.0, add layer, add data, add content, plus</remarks>
	/// <release>3.12.0</release>
	AddLayer = 59161,

	/// <summary>Add Layer Service</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.2, layers, generic, layer, layers, add, services, plus, symbol</remarks>
	/// <release>3.25.2</release>
	AddLayerService = 59162,

	/// <summary>Add Raster Variable</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, raster function template, adding, rasters, variables, function, data source</remarks>
	/// <release>3.25.2</release>
	AddRasterVariable = 59163,

	/// <summary>Add Reaction</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.21.8, generic, smile, happy, face, emoji, like, response, smile, like, satisfied</remarks>
	/// <release>3.21.8</release>
	AddReaction = 59164,

	/// <summary>Add Text</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text, type, box, words</remarks>
	/// <release>1.5</release>
	AddText = 59165,

	/// <summary>Add To Model</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.27.2, knowledge graph, add, model, edit</remarks>
	/// <release>3.27.2</release>
	AddToModel = 59166,

	/// <summary>Address Book</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.0.0, contacts, address book, person, people, spiral notebook, users, contact information, phone number, addresses</remarks>
	/// <release>3.0.0</release>
	AddressBook = 59167,

	/// <summary>Alert Off Circle (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.24.2, objects, bell, no notifications, silent, vibrate, unsubscribe, turn off, no alarm, no announcements, filled</remarks>
	/// <release>3.24.2</release>
	AlertOffCircleFilled = 59168,

	/// <summary>All Servers</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, connections, connected, networks</remarks>
	/// <release>3.20.7</release>
	AllServers = 59169,

	/// <summary>Altitude</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.1, height, gis, mountains, terrain, measure, arrow, elevation</remarks>
	/// <release>2.5.1</release>
	Altitude = 59170,

	/// <summary>Analysis</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.6.2, gis, map, points</remarks>
	/// <release>1.6.2</release>
	Analysis = 59171,

	/// <summary>Analysis Overlay</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.0, gis, map, map viewer, raster, tools, access</remarks>
	/// <release>3.21.0</release>
	AnalysisOverlay = 59172,

	/// <summary>Annotate Tool</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.1, image, pencil, edit, note, imagery, mark-up, draw, photo, picture</remarks>
	/// <release>2.5.1</release>
	AnnotateTool = 59173,

	/// <summary>Antenna Height</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.1, height, elevation, measure, device, GIS</remarks>
	/// <release>2.5.1</release>
	AntennaHeight = 59174,

	/// <summary>App Gear</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.14.5, objects, app settings, cog, app configuration, product settings, product configuration</remarks>
	/// <release>3.14.5</release>
	AppGear = 59175,

	/// <summary>App Launcher</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, grid, squares, windows, app switcher, switcher, apps, products</remarks>
	/// <release>1.5</release>
	AppLauncher = 59176,

	/// <summary>App Run</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, app-studio</remarks>
	/// <release>1.5</release>
	AppRun = 59177,

	/// <summary>App Update</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.13.1, generic, sync, reset, app update, refresh, software download, software update, software refresh</remarks>
	/// <release>3.13.1</release>
	AppUpdate = 59178,

	/// <summary>Applications</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis</remarks>
	/// <release>1.5</release>
	Applications = 59179,

	/// <summary>Apply Changes</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.25.8, arrows, direction, down, applying, change, applied</remarks>
	/// <release>3.25.8</release>
	ApplyChanges = 59180,

	/// <summary>Apply Selection To Existing View</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, change, link chart, add</remarks>
	/// <release>3.23.6</release>
	ApplySelectionToExistingView = 59181,

	/// <summary>Apps</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.7.0, applications, icons, categories, grid, logos</remarks>
	/// <release>2.7.0</release>
	Apps = 59182,

	/// <summary>ArcGIS Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, data, storage, stored, shapes, square, triangle, circle, enterprise, technology</remarks>
	/// <release>3.28.3</release>
	ArcGISDataStore = 59183,

	/// <summary>ArcGIS Online</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 1.5.0, brand, agol</remarks>
	/// <release>1.5</release>
	ArcGISOnline = 59184,

	/// <summary>Arrow Bold Down</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, directions, descending, negative, low, decrease</remarks>
	/// <release>1.5</release>
	ArrowBoldDown = 59185,

	/// <summary>Arrow Bold Left</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, directions, back, previous, backward</remarks>
	/// <release>1.5</release>
	ArrowBoldLeft = 59186,

	/// <summary>Arrow Bold Right</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, directions, go, next, forward</remarks>
	/// <release>1.5</release>
	ArrowBoldRight = 59187,

	/// <summary>Arrow Bold Up</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, directions, ascending, positive, high, increase</remarks>
	/// <release>1.5</release>
	ArrowBoldUp = 59188,

	/// <summary>Arrow Circle Down (Filled)</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.22.5, arrows, fill, circles, downloaded, arrows, saved, processed</remarks>
	/// <release>3.22.5</release>
	ArrowCircleDownFilled = 59189,

	/// <summary>Arrow Circle Down</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.22.5, arrows, circles, downloaded, arrows, saved, processed</remarks>
	/// <release>3.22.5</release>
	ArrowCircleDown = 59190,

	/// <summary>Arrow Double Diagonal 1</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, arrow double diagonal, diagonal upward</remarks>
	/// <release>3.7.0</release>
	ArrowDoubleDiagonal1 = 59191,

	/// <summary>Arrow Double Diagonal 2</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, arrow double diagonal, diagonal downward</remarks>
	/// <release>3.7.0</release>
	ArrowDoubleDiagonal2 = 59192,

	/// <summary>Arrow Double Horizontal</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, arrow double horizontal, left and right</remarks>
	/// <release>3.7.0</release>
	ArrowDoubleHorizontal = 59193,

	/// <summary>Arrow Double Vertical</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, arrow double vertical, up and down</remarks>
	/// <release>3.7.0</release>
	ArrowDoubleVertical = 59194,

	/// <summary>Arrow Down</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, below, descending, low, negative, shrink, decrease</remarks>
	/// <release>1.5</release>
	ArrowDown = 59195,

	/// <summary>Arrow Down Left</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, previous, back, behind, southwest, sw, arrow left down, move, scale, point, direction, angle, bottom left corner, arrow down left, diagonal</remarks>
	/// <release>1.5</release>
	ArrowDownLeft = 59196,

	/// <summary>Arrow Down Right</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, front, forward, ahead, next, southeast, se, arrow right down, move, scale, point, direction, angle, bottom right corner, arrow down right, diagonal</remarks>
	/// <release>1.5</release>
	ArrowDownRight = 59197,

	/// <summary>Arrow Left</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, previous, back, behind</remarks>
	/// <release>1.5</release>
	ArrowLeft = 59198,

	/// <summary>Arrow Right</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, next, forward, go</remarks>
	/// <release>1.5</release>
	ArrowRight = 59199,

	/// <summary>Arrow Right Left</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, arrow right left, back and forth, forward backward, switch, lanes</remarks>
	/// <release>3.7.0</release>
	ArrowRightLeft = 59200,

	/// <summary>Arrow Up</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, above, ascending, high, positive, grow, increase</remarks>
	/// <release>1.5</release>
	ArrowUp = 59201,

	/// <summary>Arrow Up Down</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, reverse, switch, re-order, reorder, back and forth, opposite, sort, update</remarks>
	/// <release>1.5</release>
	ArrowUpDown = 59202,

	/// <summary>Arrow Up Left</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, previous, back, behind, northwest, nw, arrow left up, move, scale, point, direction, angle, top left corner, arrow up left, diagonal</remarks>
	/// <release>1.5</release>
	ArrowUpLeft = 59203,

	/// <summary>Arrow Up Right</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, front, forward, ahead, next, northeast, ne, arrow right up, move, scale, point, direction, angle, top right corner, arrow up right, diagonal</remarks>
	/// <release>1.5</release>
	ArrowUpRight = 59204,

	/// <summary>Article</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, news, blog</remarks>
	/// <release>1.5</release>
	Article = 59205,

	/// <summary>Asterisk Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.21.6, asterisk, required, symbol, large, star, starburst</remarks>
	/// <release>3.21.6</release>
	AsteriskLarge = 59206,

	/// <summary>Asterisk Small</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.21.6, asterisk, required, symbol, small, star, starburst</remarks>
	/// <release>3.21.6</release>
	AsteriskSmall = 59207,

	/// <summary>Attachment</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects</remarks>
	/// <release>1.5</release>
	Attachment = 59208,

	/// <summary>Attachment Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.13.0, attachment plus, add, plus, file, paper clip</remarks>
	/// <release>3.13.0</release>
	AttachmentPlus = 59209,

	/// <summary>Auto Layout</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.25.2, symbols, online model builder, shapes, circles, squares, layouts, template, organize, automatic</remarks>
	/// <release>3.25.2</release>
	AutoLayout = 59210,

	/// <summary>Automation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, automate, arrows, process, workflow</remarks>
	/// <release>1.5</release>
	Automation = 59211,

	/// <summary>Banana</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, app-studio</remarks>
	/// <release>1.5</release>
	Banana = 59212,

	/// <summary>Basemap</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis</remarks>
	/// <release>1.5</release>
	Basemap = 59213,

	/// <summary>Battery 1</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, percentage, critical, low, 25%</remarks>
	/// <release>1.5</release>
	Battery1 = 59214,

	/// <summary>Battery 2</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, percentage, half, 50%</remarks>
	/// <release>1.5</release>
	Battery2 = 59215,

	/// <summary>Battery 3</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, percentage, high, 75%</remarks>
	/// <release>1.5</release>
	Battery3 = 59216,

	/// <summary>Battery 4</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, percentage, fully charged, 100%</remarks>
	/// <release>1.5</release>
	Battery4 = 59217,

	/// <summary>Battery Charging</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, charge, lightning bolt</remarks>
	/// <release>1.5</release>
	BatteryCharging = 59218,

	/// <summary>Beacon</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: generic, 3.17.0, radar, connect, wifi, rays, internet of things, iot, signal, communication</remarks>
	/// <release>3.17.0</release>
	Beacon = 59219,

	/// <summary>Beaker</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, science, lab, research, experiment</remarks>
	/// <release>1.5</release>
	Beaker = 59220,

	/// <summary>Bear Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	BearLeft = 59221,

	/// <summary>Bear Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	BearRight = 59222,

	/// <summary>Beginning (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, start, first, media, filled</remarks>
	/// <release>1.5</release>
	BeginningFilled = 59223,

	/// <summary>Beginning</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, start, first, media</remarks>
	/// <release>1.5</release>
	Beginning = 59224,

	/// <summary>Bell (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.14.5, objects, notification, alert, alarm, bell, filled</remarks>
	/// <release>3.14.5</release>
	BellFilled = 59225,

	/// <summary>Bell</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.14.5, objects, notification, alert, alarm, bell</remarks>
	/// <release>3.14.5</release>
	Bell = 59226,

	/// <summary>Bell Off</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.0.0, no notifications, bell off, silent, vibrate, silent mode, unsubscribe, turn off notifications, no alarm, no announcements</remarks>
	/// <release>3.0.0</release>
	BellOff = 59227,

	/// <summary>Beta</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.0.0, text, symbols, characters, greek, mathematics, calculations, variable</remarks>
	/// <release>3.0.0</release>
	Beta = 59228,

	/// <summary>Biking</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, bike, bicycle, bicycling, ride, sport, people, person, commute, commuting, exercise, activity, transportation</remarks>
	/// <release>1.5</release>
	Biking = 59229,

	/// <summary>Binary</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.28.1, text, digits, data, numbers, calculate</remarks>
	/// <release>3.28.1</release>
	Binary = 59230,

	/// <summary>Blank</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, placeholder, blank, empty, replacement, spacer, toggle off, off state, empty state</remarks>
	/// <release>3.0.0</release>
	Blank = 59231,

	/// <summary>Blog</summary>
	/// <remarks>Category: Social Media<br/>
	/// Alias: 1.5.0, social-media, social</remarks>
	/// <release>1.5</release>
	Blog = 59232,

	/// <summary>Bluetooth</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.1, device, connection, connected, symbols, technology, sharing</remarks>
	/// <release>2.5.1</release>
	Bluetooth = 59233,

	/// <summary>Bold</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Bold = 59234,

	/// <summary>Book</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.10.0, dictionary, book cover, binder, reference book, literature</remarks>
	/// <release>3.10.0</release>
	Book = 59235,

	/// <summary>Bookmark (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.1, objects, fill, marking, save, label, bookmarking</remarks>
	/// <release>3.20.1</release>
	BookmarkFilled = 59236,

	/// <summary>Bookmark</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects</remarks>
	/// <release>1.5</release>
	Bookmark = 59237,

	/// <summary>Boolean</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 2.5.3, true or false, false or true, letters, text, 1 or 0, 0 or 1, on or off, off or on, switch, datatype</remarks>
	/// <release>2.5.3</release>
	Boolean = 59238,

	/// <summary>Border Radius Fully Rounded</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.9, generic, corner, curve, shape, lines, area, circle</remarks>
	/// <release>3.20.9</release>
	BorderRadiusFullyRounded = 59239,

	/// <summary>Border Radius Rounded</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.9, generic, corner, curve, shape, lines, area</remarks>
	/// <release>3.20.9</release>
	BorderRadiusRounded = 59240,

	/// <summary>Border Radius Sharp</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.9, generic, corner, straight, shape, lines, square, area</remarks>
	/// <release>3.20.9</release>
	BorderRadiusSharp = 59241,

	/// <summary>Box Chart</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts and graphs, graph, data, plot, box plot, summarize, interval scale, scale, analysis, distribution, variability, central value, chart</remarks>
	/// <release>1.5</release>
	BoxChart = 59242,

	/// <summary>Brackets</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.1, generic, code, coding, programmer, syntax, script, html</remarks>
	/// <release>3.28.1</release>
	Brackets = 59243,

	/// <summary>Brackets Curly</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.1, generic, code, coding, syntax, developer, js, html, python, ruby, script, programmer, css</remarks>
	/// <release>3.0.1</release>
	BracketsCurly = 59244,

	/// <summary>Break Recurrence</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.25.2, directions, indoors, breaking, arrows, turns, curves, loop, broken, fractured</remarks>
	/// <release>3.24.6</release>
	BreakRecurrence = 59245,

	/// <summary>Brightness</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, light-theme, light-mode, light, dim, brightness setting, weather, sky, forecast, sunshine, sunny, day mode</remarks>
	/// <release>1.5</release>
	Brightness = 59246,

	/// <summary>Bring Forward</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.16.5, front, move, stack, layers, squares, in front, order</remarks>
	/// <release>3.16.5</release>
	BringForward = 59247,

	/// <summary>Bring To Front</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.16.5, front, move, stack, layers, squares, in front, order</remarks>
	/// <release>3.16.5</release>
	BringToFront = 59248,

	/// <summary>Browser</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, os, window</remarks>
	/// <release>1.5</release>
	Browser = 59249,

	/// <summary>Brush Mark</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.6.0, brush mark, brushstroke, brush stroke, painting, drawing, canvas, artist</remarks>
	/// <release>3.6.0</release>
	BrushMark = 59250,

	/// <summary>Brush Mark Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.13.0, brush mark plus, brushstroke, brush stroke, painting, drawing, canvas, artist, add, plus, paint</remarks>
	/// <release>3.13.0</release>
	BrushMarkPlus = 59251,

	/// <summary>Brush Tip</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, drawing, tool, instrument, painting, art, freehand, illustrate, design</remarks>
	/// <release>3.16.6</release>
	BrushTip = 59252,

	/// <summary>Bullet Point</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.24.2, generic, bullet point, point, circle, dot</remarks>
	/// <release>3.24.2</release>
	BulletPoint = 59253,

	/// <summary>Bullet Point Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.24.2, generic, bullet, point, circle, dot</remarks>
	/// <release>3.24.2</release>
	BulletPointLarge = 59254,

	/// <summary>Button</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.3.0, CTA, call to action, prompt, OK</remarks>
	/// <release>3.3.0</release>
	Button = 59255,

	/// <summary>Calculator</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, addition, subtraction, division, multiplication, calculate, compute, function, expression, mathematics</remarks>
	/// <release>1.5</release>
	Calculator = 59256,

	/// <summary>Calendar</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, event, schedule, date, appointment</remarks>
	/// <release>1.5</release>
	Calendar = 59257,

	/// <summary>Camera</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, video, photograph, picture, point and shoot, handheld, snapshot, attractions, tourism, tourist, point of interest, poi, device, technology</remarks>
	/// <release>1.5</release>
	Camera = 59258,

	/// <summary>Camera Flash Off</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.1, camera, light, lighting, aperture, lens, toggle, brightness, capture, photo</remarks>
	/// <release>2.5.1</release>
	CameraFlashOff = 59259,

	/// <summary>Camera Flash On</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.1, camera, light, lighting, aperture, lens, toggle, brightness, capture, photo</remarks>
	/// <release>2.5.1</release>
	CameraFlashOn = 59260,

	/// <summary>Camera Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.13.0, objects, video, photograph, picture, point and shoot, handheld, snapshot, attractions, tourism, tourist, point of interest, poi, device, technology, plus, add, add photo, upload photo, take photo, add image, upload image</remarks>
	/// <release>3.13.0</release>
	CameraPlus = 59261,

	/// <summary>Camera Switch Front Back</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.1, selfie, flip, reverse, lens, photo, picture, image, capture, handheld, photography, device, technology</remarks>
	/// <release>2.5.1</release>
	CameraSwitchFrontBack = 59262,

	/// <summary>Camera Unlock</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.0, objects, video, photograph, picture, point and shoot, handheld, snapshot, device, technology, lock</remarks>
	/// <release>3.15.0</release>
	CameraUnlock = 59263,

	/// <summary>Car</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, automobile, transportation, motor vehicle, sedan, commute, commuting, driving, drive</remarks>
	/// <release>1.5</release>
	Car = 59264,

	/// <summary>Caret Double Horizontal</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.7.0, caret double horizontal, slider, drag, left and right</remarks>
	/// <release>3.7.0</release>
	CaretDoubleHorizontal = 59265,

	/// <summary>Caret Double Vertical</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.7.0, caret double vertical, elevator button, drag up and down, slide, lift button, scroll</remarks>
	/// <release>3.7.0</release>
	CaretDoubleVertical = 59266,

	/// <summary>Caret Down</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, triangle, negative, accordion, dropdown</remarks>
	/// <release>1.5</release>
	CaretDown = 59267,

	/// <summary>Caret Left</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, triangle, previous, backward</remarks>
	/// <release>1.5</release>
	CaretLeft = 59268,

	/// <summary>Caret Right</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, collapse, expand, triangle, next, forward, accordion, dropdown</remarks>
	/// <release>1.5</release>
	CaretRight = 59269,

	/// <summary>Caret Square Down</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, collapse, expand, right, down, left, up, triangle, next, previous, forward, backward, accordion, dropdown</remarks>
	/// <release>1.5</release>
	CaretSquareDown = 59270,

	/// <summary>Caret Square Left</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, triangle, back, previous, accordion</remarks>
	/// <release>1.5</release>
	CaretSquareLeft = 59271,

	/// <summary>Caret Square Right</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, collapse, expand, triangle, next, forward, accordion, dropdown</remarks>
	/// <release>1.5</release>
	CaretSquareRight = 59272,

	/// <summary>Caret Square Up</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, collapse, expand, right, down, left, up, triangle, next, previous, forward, backward, accordion, dropdown</remarks>
	/// <release>1.5</release>
	CaretSquareUp = 59273,

	/// <summary>Caret Up</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, triangle, positive</remarks>
	/// <release>1.5</release>
	CaretUp = 59274,

	/// <summary>Center Align</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.17.7, text, typography, alignment, paragraph, type, body text, format, justification, justify</remarks>
	/// <release>3.17.7</release>
	CenterAlign = 59275,

	/// <summary>Center Horizontal</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, center horizontal, middle horizontal, align center, align middle</remarks>
	/// <release>3.7.0</release>
	CenterHorizontal = 59276,

	/// <summary>Center Vertical</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, center vertical, middle vertical, align middle, align center</remarks>
	/// <release>3.7.0</release>
	CenterVertical = 59277,

	/// <summary>Certificate</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, paper, award, certification, passed, achievement, diploma, ribbon</remarks>
	/// <release>3.15.2</release>
	Certificate = 59278,

	/// <summary>Change Font Size</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.26.6, text, font, size, change, edit, increase, decrease</remarks>
	/// <release>3.26.6</release>
	ChangeFontSize = 59279,

	/// <summary>Channels</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.23.6, generic, discussion, api, chat, teams, text, post, social</remarks>
	/// <release>3.23.6</release>
	Channels = 59280,

	/// <summary>Chart Gear</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.14.9, chart gear, configure chart, configure graph, chart settings, graph settings, chart configuration, graph configuration, bar chart</remarks>
	/// <release>3.14.9</release>
	ChartGear = 59281,

	/// <summary>Chart Magnifying Glass</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.19.4, charts and graphs, analyze, analytics, analysis, inspect, visualize, graph, data, look, view, output, diagram</remarks>
	/// <release>3.19.4</release>
	ChartMagnifyingGlass = 59282,

	/// <summary>Check</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, mark, selected</remarks>
	/// <release>1.5</release>
	Check = 59283,

	/// <summary>Check Circle (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, check, mark, selected, circle, filled</remarks>
	/// <release>1.5</release>
	CheckCircleFilled = 59284,

	/// <summary>Check Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, check, mark, selected, circle</remarks>
	/// <release>1.5</release>
	CheckCircle = 59285,

	/// <summary>Check Extent</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.17.5, symbols, done, box, tick, selection, area, tick, check mark, confirm, correct, selected, precision, accuracy, success</remarks>
	/// <release>3.17.5</release>
	CheckExtent = 59286,

	/// <summary>Check Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, active, success, select, enable, approved, correct, ready</remarks>
	/// <release>1.5</release>
	CheckLayer = 59287,

	/// <summary>Check Shield</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, safety, insurance, protection, insured, secure, security, anti-virus, cybersecurity, defense, protected, warranty, coverage</remarks>
	/// <release>3.15.2</release>
	CheckShield = 59288,

	/// <summary>Check Square (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, done, box, select, tick, check mark, toggle, confirm, correct, selected, filled</remarks>
	/// <release>1.5</release>
	CheckSquareFilled = 59289,

	/// <summary>Check Square</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, done, box, select, tick, check mark, toggle, confirm, correct, selected</remarks>
	/// <release>1.5</release>
	CheckSquare = 59290,

	/// <summary>Chevron Down</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronDown = 59291,

	/// <summary>Chevron Down Left</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.6, symbols, arrow, direction, keypad</remarks>
	/// <release>3.23.6</release>
	ChevronDownLeft = 59292,

	/// <summary>Chevron Down Right</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.6, symbols, arrow, direction, keypad</remarks>
	/// <release>3.23.6</release>
	ChevronDownRight = 59293,

	/// <summary>Chevron End</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.24.5, media, arrow, back, revert, finish, close</remarks>
	/// <release>3.24.5</release>
	ChevronEnd = 59294,

	/// <summary>Chevron Left</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronLeft = 59295,

	/// <summary>Chevron Right</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronRight = 59296,

	/// <summary>Chevron Start</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.24.5, media, arrow, next, begin, first</remarks>
	/// <release>3.24.5</release>
	ChevronStart = 59297,

	/// <summary>Chevron Up</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronUp = 59298,

	/// <summary>Chevron Up Left</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.6, symbols, arrow, direction, keypad</remarks>
	/// <release>3.23.6</release>
	ChevronUpLeft = 59299,

	/// <summary>Chevron Up Right</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.6, symbols, arrow, direction, keypad</remarks>
	/// <release>3.23.6</release>
	ChevronUpRight = 59300,

	/// <summary>Chevrons Down</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronsDown = 59301,

	/// <summary>Chevrons Left</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronsLeft = 59302,

	/// <summary>Chevrons Right</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronsRight = 59303,

	/// <summary>Chevrons Up</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, arrow</remarks>
	/// <release>1.5</release>
	ChevronsUp = 59304,

	/// <summary>Chord Diagram</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, Charts and graphs, charts, graph, data, matrix, circle, arcs, analysis</remarks>
	/// <release>1.5</release>
	ChordDiagram = 59305,

	/// <summary>Circle (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, radio, shape, empty, button, filled</remarks>
	/// <release>1.5</release>
	CircleFilled = 59306,

	/// <summary>Circle</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, radio, shape, empty, button</remarks>
	/// <release>1.5</release>
	Circle = 59307,

	/// <summary>Circle Disallowed</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, ban, cancel, none, null, no entry, empty, not allowed, banned, not prohibited</remarks>
	/// <release>1.5</release>
	CircleDisallowed = 59308,

	/// <summary>Circle Inset Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, button, circle, bold</remarks>
	/// <release>3.28.8</release>
	CircleInsetLarge = 59309,

	/// <summary>Circle Inset Medium</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, circle, bold, filled</remarks>
	/// <release>3.28.8</release>
	CircleInsetMedium = 59310,

	/// <summary>Circle Inset Small</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, circle, filled</remarks>
	/// <release>3.28.8</release>
	CircleInsetSmall = 59311,

	/// <summary>Circle Pause (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.0, symbols, stop, hold, pausing, waiting, slow, status, filled</remarks>
	/// <release>3.23.0</release>
	CirclePauseFilled = 59312,

	/// <summary>Circle Pause</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.0, symbols, stop, hold, pausing, waiting, slow, status</remarks>
	/// <release>3.23.0</release>
	CirclePause = 59313,

	/// <summary>Circle Stop (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.24.1, symbols, cube, stop, halt, end, finish, button, filled</remarks>
	/// <release>3.24.1</release>
	CircleStopFilled = 59314,

	/// <summary>Circle Stop</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.24.1, symbols, cube, stop, halt, end, finish, button</remarks>
	/// <release>3.24.1</release>
	CircleStop = 59315,

	/// <summary>Classify Objects</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, classify</remarks>
	/// <release>3.17.1</release>
	ClassifyObjects = 59316,

	/// <summary>Clear Selection</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, knowledge graph, map, area, erase, perimeter</remarks>
	/// <release>3.25.2</release>
	ClearSelection = 59317,

	/// <summary>Clipboard</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.2, objects, files, written, notes, organize, list, order</remarks>
	/// <release>3.18.2</release>
	Clipboard = 59318,

	/// <summary>Clipboard Brackets</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.27.7, objects, select, clipboard, frame</remarks>
	/// <release>3.27.7</release>
	ClipboardBrackets = 59319,

	/// <summary>Clock</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, time, history, date</remarks>
	/// <release>1.5</release>
	Clock = 59320,

	/// <summary>Clock Down</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, time, date, sort, descending</remarks>
	/// <release>1.5</release>
	ClockDown = 59321,

	/// <summary>Clock Forward</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.18.6, arrows, arrow, movement, time, refresh</remarks>
	/// <release>3.18.6</release>
	ClockForward = 59322,

	/// <summary>Clock Up</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, time, date, sort, ascending</remarks>
	/// <release>1.5</release>
	ClockUp = 59323,

	/// <summary>Closed Caption (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.29.3, media, media, audio, video, display, text, information, filled</remarks>
	/// <release>3.29.3</release>
	ClosedCaptionFilled = 59324,

	/// <summary>Closed Caption</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.29.3, media, media, audio, video, display, text, information</remarks>
	/// <release>3.29.3</release>
	ClosedCaption = 59325,

	/// <summary>Cloud</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: symbols, 3.16.5, connected, internet, connection, syncing, the cloud, service, hosting</remarks>
	/// <release>3.16.5</release>
	Cloud = 59326,

	/// <summary>Cloud Data</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, cloud, data, canister, storage</remarks>
	/// <release>3.28.3</release>
	CloudData = 59327,

	/// <summary>Cloud Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, storage, servers, syncing</remarks>
	/// <release>3.28.3</release>
	CloudServer = 59328,

	/// <summary>Cloudy</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, wind, stormy</remarks>
	/// <release>3.17.6</release>
	Cloudy = 59329,

	/// <summary>Code</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, developer, script, programmer, css, javascript, js, html, python, ruby</remarks>
	/// <release>1.5</release>
	Code = 59330,

	/// <summary>Code Branch</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.26.4, knowledge graph, Branch, management, connections</remarks>
	/// <release>3.26.4</release>
	CodeBranch = 59331,

	/// <summary>Code Branch Edit</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.26.4, knowledge graph, branch, management, edit, pencil, connections</remarks>
	/// <release>3.26.4</release>
	CodeBranchEdit = 59332,

	/// <summary>Collaboration</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.7, Generic, network, circles, community, connection, enclosed, share, sharing, collaborative, diagram</remarks>
	/// <release>3.19.7</release>
	Collaboration = 59333,

	/// <summary>Collaboration Distributed</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.7, Generic, network, circles, community, connection, enclosed, share, sharing, collaborative, diagram, distribution, open</remarks>
	/// <release>3.19.7</release>
	CollaborationDistributed = 59334,

	/// <summary>Collaboration User</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.24.9, people, person, teamwork, partnership, network, circles, community, connection, enclosed, share, sharing, collaborative, diagram</remarks>
	/// <release>3.24.9</release>
	CollaborationUser = 59335,

	/// <summary>Collection</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, image, map</remarks>
	/// <release>1.5</release>
	Collection = 59336,

	/// <summary>Column Settings</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.6, generic, windows, table, view, gears, configurations, cog, preferences, options</remarks>
	/// <release>3.25.6</release>
	ColumnSettings = 59337,

	/// <summary>Community Link Chart Layout</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial data, spatial analysis, data model</remarks>
	/// <release>3.23.6</release>
	CommunityLinkChartLayout = 59338,

	/// <summary>Compactness</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.18.9, gis, map, area, territory, zoom, district, dotted line</remarks>
	/// <release>3.18.9</release>
	Compactness = 59339,

	/// <summary>Compare</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, swipe, side by side, difference, slide</remarks>
	/// <release>1.5</release>
	Compare = 59340,

	/// <summary>Compass</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, directions, my-location, gps, north, south, east, west, explore</remarks>
	/// <release>1.5</release>
	Compass = 59341,

	/// <summary>Compass Needle</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, orientation, directions, cardinal, north, south, compass rose</remarks>
	/// <release>1.5</release>
	CompassNeedle = 59342,

	/// <summary>Compass North Circle</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, directions, my-location, gps</remarks>
	/// <release>1.5</release>
	CompassNorthCircle = 59343,

	/// <summary>Conditional Rules</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.0.0, automation, conditional rules, prerequisites, requirements, dependencies</remarks>
	/// <release>3.0.0-beta.6</release>
	ConditionalRules = 59344,

	/// <summary>Conditional Rules Path</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.0.0, automation, conditional rules path, prerequisites, requirements, dependencies</remarks>
	/// <release>3.0.0-beta.6</release>
	ConditionalRulesPath = 59345,

	/// <summary>Conference Room</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, table, people, person, conference room, conference table, meeting room, congregate</remarks>
	/// <release>3.0.0</release>
	ConferenceRoom = 59346,

	/// <summary>Configure</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.1, generic, data, window, gear, tool, settings, manage, tools, wrench, options, list, menu</remarks>
	/// <release>3.19.1</release>
	Configure = 59347,

	/// <summary>Configure Editing</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.27.0, lists, edit, write, note, settings</remarks>
	/// <release>3.27.0</release>
	ConfigureEditing = 59348,

	/// <summary>Configure Grid Unit</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, indoors, grids, modify, gear, changes, units, spaces</remarks>
	/// <release>3.25.2</release>
	ConfigureGridUnit = 59349,

	/// <summary>Configure Popup</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, gear, popup settings, popup configuration, design, cog</remarks>
	/// <release>1.5</release>
	ConfigurePopup = 59350,

	/// <summary>Connection End Left</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.29.5, generic, line, point, connect, end, left</remarks>
	/// <release>3.29.5</release>
	ConnectionEndLeft = 59351,

	/// <summary>Connection End Right</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.29.5, generic, line, point, connect, right, end</remarks>
	/// <release>3.29.5</release>
	ConnectionEndRight = 59352,

	/// <summary>Connection Middle</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.29.5, generic, line, point, middle, connect</remarks>
	/// <release>3.29.5</release>
	ConnectionMiddle = 59353,

	/// <summary>Connection To Connection</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.29.5, generic, connect, two points, line</remarks>
	/// <release>3.29.5</release>
	ConnectionToConnection = 59354,

	/// <summary>Console</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, app-studio, terminal</remarks>
	/// <release>1.5</release>
	Console = 59355,

	/// <summary>Content Full</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.7.0, content full, cover, hero image, banner</remarks>
	/// <release>3.7.0</release>
	ContentFull = 59356,

	/// <summary>Content Inline</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, image wrap, content inline, image inline</remarks>
	/// <release>3.3.0</release>
	ContentInline = 59357,

	/// <summary>Content Inline Right</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.32.0, windows, text, line, image inline, right, image wrap</remarks>
	/// <release>3.32.0</release>
	ContentInlineRight = 59358,

	/// <summary>Content Large</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, hero image, banner image, content large, large content, hero banner</remarks>
	/// <release>3.3.0</release>
	ContentLarge = 59359,

	/// <summary>Content Medium</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, content medium, image, dynamic content, interactive content</remarks>
	/// <release>3.3.0</release>
	ContentMedium = 59360,

	/// <summary>Content Minimal</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.7.0, content minimal, cover</remarks>
	/// <release>3.7.0</release>
	ContentMinimal = 59361,

	/// <summary>Content None</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.7.0, content none, no content, cover</remarks>
	/// <release>3.7.0</release>
	ContentNone = 59362,

	/// <summary>Content Side By Side</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.7.0, content side by side, cover, sidebar</remarks>
	/// <release>3.7.0</release>
	ContentSideBySide = 59363,

	/// <summary>Content Small</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, inline content, content small, column content, small image, inline image</remarks>
	/// <release>3.3.0</release>
	ContentSmall = 59364,

	/// <summary>Contingent Values</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.18.6, forms, table, value, connected, levels, field, forms, dependent, conditional</remarks>
	/// <release>3.18.6</release>
	ContingentValues = 59365,

	/// <summary>Contract</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, reduce, scale down</remarks>
	/// <release>3.7.0</release>
	Contract = 59366,

	/// <summary>Contrast</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, color, brightness, picture settings, image settings, image adjustments, photography, white balance, light, lighting, shadows, highlights, midtones, threshold, black and white</remarks>
	/// <release>3.0.0</release>
	Contrast = 59367,

	/// <summary>Convert</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.8, generic, files, change, types, forms</remarks>
	/// <release>3.17.8</release>
	Convert = 59368,

	/// <summary>Coordinate System</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.21.0, generic, globe, global, earth, latitude, longitude, map, planet, sphere</remarks>
	/// <release>3.21.0</release>
	CoordinateSystem = 59369,

	/// <summary>Copy</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, duplicate, clone</remarks>
	/// <release>1.5</release>
	Copy = 59370,

	/// <summary>Copy To Clipboard</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, duplicate, clone</remarks>
	/// <release>1.5</release>
	CopyToClipboard = 59371,

	/// <summary>Credit Card</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.6, objects, money, payment, currency, price, paypal, checkout, atm, purchase, withdrawal, deposit, transaction, finances, bank, charge, sale, buy, wallet, debit card, shopping cart</remarks>
	/// <release>3.18.6</release>
	CreditCard = 59372,

	/// <summary>Credits</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.8.0, coins, assign credits, money, cash, change, currency, payment, price, paypal, checkout, atm, cash, change, purchase, withdrawal, deposit, transaction, finances, bank, charge, sale, buy, wallet</remarks>
	/// <release>1.8.0</release>
	Credits = 59373,

	/// <summary>Crop</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.14.8, Generic, trim, clip</remarks>
	/// <release>3.14.8</release>
	Crop = 59374,

	/// <summary>Cube</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, 3d</remarks>
	/// <release>1.5</release>
	Cube = 59375,

	/// <summary>Cursor</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, point and click</remarks>
	/// <release>1.5</release>
	Cursor = 59376,

	/// <summary>Cursor Click</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, point and click</remarks>
	/// <release>1.5</release>
	CursorClick = 59377,

	/// <summary>Cursor Lock</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.7.0, cursor lock, lock interaction, restricted</remarks>
	/// <release>3.7.0</release>
	CursorLock = 59378,

	/// <summary>Cursor Marquee</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, drag-box, box-select, select, marquee</remarks>
	/// <release>1.5</release>
	CursorMarquee = 59379,

	/// <summary>Cursor Minus</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, web editor, select, click, choose, subtract, erase, deselect</remarks>
	/// <release>3.25.2</release>
	CursorMinus = 59380,

	/// <summary>Cursor Plus</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.2.0, cursor plus, cursor add, point add, point plus</remarks>
	/// <release>3.2.0</release>
	CursorPlus = 59381,

	/// <summary>Curve</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.25.2, geometry editing, web editor, angles, select, points, curves, lines</remarks>
	/// <release>3.25.2</release>
	Curve = 59382,

	/// <summary>Cut And Fill Volume Calculation</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.6.1, space, void, difference</remarks>
	/// <release>1.6.1</release>
	CutAndFillVolumeCalculation = 59383,

	/// <summary>Dashboard</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, gauge, statistics, measurement, capacity</remarks>
	/// <release>1.5</release>
	Dashboard = 59384,

	/// <summary>Data</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, server, database</remarks>
	/// <release>1.5</release>
	Data = 59385,

	/// <summary>Data Card</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, knowledge graph, data, card, visualization, information</remarks>
	/// <release>3.25.2</release>
	DataCard = 59386,

	/// <summary>Data Check</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, compatible, database, database confirmed, database correct, database approved, database ready</remarks>
	/// <release>1.5</release>
	DataCheck = 59387,

	/// <summary>Data Clock Chart</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts and graphs, circular chart, chart, graph, time, rings, temporal bins, time period, summarize, value, analysis</remarks>
	/// <release>1.5</release>
	DataClockChart = 59388,

	/// <summary>Data Cloud</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, cloud, database, data</remarks>
	/// <release>3.17.1</release>
	DataCloud = 59389,

	/// <summary>Data Folder</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, database, folder, data</remarks>
	/// <release>3.17.1</release>
	DataFolder = 59390,

	/// <summary>Data Magnifying Glass</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.7, generic, database, search, locate, find, analyze, identify, browse</remarks>
	/// <release>3.16.7</release>
	DataMagnifyingGlass = 59391,

	/// <summary>Date Time</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.23.4, objects, time, schedule, appointment, calendar</remarks>
	/// <release>3.23.4</release>
	DateTime = 59392,

	/// <summary>Debug</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.13.0, generic, debug, troubleshoot, issues, fix, solve, technology, analyze, inspect, errors, detect, hardware, software</remarks>
	/// <release>3.13.0</release>
	Debug = 59393,

	/// <summary>Debug Script</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.1, generic, bug, search, find, magnifying glass, locate, diagnose, troubleshoot, issues, fix, solve, technology, analyze, inspect, errors, detect, hardware, software</remarks>
	/// <release>3.19.1</release>
	DebugScript = 59394,

	/// <summary>Decrease Link Chart Symbol Size</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, circle, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model</remarks>
	/// <release>3.20.6</release>
	DecreaseLinkChartSymbolSize = 59395,

	/// <summary>Deep Learning</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.4, deep learning, ai, machine learning, neural map, diagram, nodes, web</remarks>
	/// <release>2.5.4</release>
	DeepLearning = 59396,

	/// <summary>Deep Learning Project</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 2.5.4, briefcase, deep learning project, ai, nodes, machine learning</remarks>
	/// <release>2.5.4</release>
	DeepLearningProject = 59397,

	/// <summary>Derived Value</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.25.2, forms, online model builder, arrow, data, values, information</remarks>
	/// <release>3.25.2</release>
	DerivedValue = 59398,

	/// <summary>Description</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, abc, text</remarks>
	/// <release>1.5</release>
	Description = 59399,

	/// <summary>Desk</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.0.0, table, office space, cubicle, co-working space</remarks>
	/// <release>3.0.0</release>
	Desk = 59400,

	/// <summary>Desktop</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, computer, monitor, windows</remarks>
	/// <release>1.6</release>
	Desktop = 59401,

	/// <summary>Developer Credentials</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.2, generic, key, token, access, apps</remarks>
	/// <release>3.28.2</release>
	DeveloperCredentials = 59402,

	/// <summary>Diamond</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.8, generic, shape, symbol, glyph</remarks>
	/// <release>3.16.8</release>
	Diamond = 59403,

	/// <summary>Diamond Inset Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, diamond, type, symbol, glyph</remarks>
	/// <release>3.28.8</release>
	DiamondInsetLarge = 59404,

	/// <summary>Diamond Inset Medium</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, diamond, filled</remarks>
	/// <release>3.28.8</release>
	DiamondInsetMedium = 59405,

	/// <summary>Diamond Inset Small</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, diamond, filled</remarks>
	/// <release>3.28.8</release>
	DiamondInsetSmall = 59406,

	/// <summary>Dimensions</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.4, generic, measure, size, scale, width, height, dimensions</remarks>
	/// <release>3.20.4</release>
	Dimensions = 59407,

	/// <summary>Dimensions Unit</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, units, size, length, spaces, measurements, arrows, height, width</remarks>
	/// <release>3.25.2</release>
	DimensionsUnit = 59408,

	/// <summary>Dimensions Wall</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, walls, size, length, spaces, measurements, arrows, height</remarks>
	/// <release>3.25.2</release>
	DimensionsWall = 59409,

	/// <summary>Discard</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, exclude, negate, cut out</remarks>
	/// <release>3.0.0</release>
	Discard = 59410,

	/// <summary>Disembark</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, ship, exit, departures, transportation, navigation</remarks>
	/// <release>1.5</release>
	Disembark = 59411,

	/// <summary>Dissolve Features</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.19.0, gis, shapes, map, area, merge, combine, polygons, unite</remarks>
	/// <release>3.19.0</release>
	DissolveFeatures = 59412,

	/// <summary>Distance Type</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.18.9, gis, measure, list, category, space</remarks>
	/// <release>3.18.9</release>
	DistanceType = 59413,

	/// <summary>Distribute Height Evenly</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.2, distribute height evenly, boxes, disperse, UI, interface, align, alignment, arrows, tall</remarks>
	/// <release>3.17.2</release>
	DistributeHeightEvenly = 59414,

	/// <summary>Distribute Width Evenly</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.2, distribute width evenly, boxes, disperse, UI, interface, align, alignment, arrows, wide, horizontal</remarks>
	/// <release>3.17.2</release>
	DistributeWidthEvenly = 59415,

	/// <summary>Dock Bottom</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, footer, panel</remarks>
	/// <release>1.5</release>
	DockBottom = 59416,

	/// <summary>Dock Left</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, sidebar, toc, panel</remarks>
	/// <release>1.5</release>
	DockLeft = 59417,

	/// <summary>Dock Right</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, sidebar, panel</remarks>
	/// <release>1.5</release>
	DockRight = 59418,

	/// <summary>Double Float</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.27.2, text, precision, digits, data, type</remarks>
	/// <release>3.27.2</release>
	DoubleFloat = 59419,

	/// <summary>Download To</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, import</remarks>
	/// <release>1.5</release>
	DownloadTo = 59420,

	/// <summary>Drag</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 2.5.0, move, dots, grid, click and drag, drag and drop</remarks>
	/// <release>2.5.0</release>
	Drag = 59421,

	/// <summary>Drive Time</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, navigation, driving, routes, map, visualization, mapping</remarks>
	/// <release>3.17.5</release>
	DriveTime = 59422,

	/// <summary>Drive Time Largest</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, navigation, driving, routes, map, visualization, mapping</remarks>
	/// <release>3.17.5</release>
	DriveTimeLargest = 59423,

	/// <summary>Drive Time Smallest</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, navigation, driving, routes, map, visualization, mapping</remarks>
	/// <release>3.17.5</release>
	DriveTimeSmallest = 59424,

	/// <summary>Drive Time Threshold</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.6, gis, drive, time, threshold</remarks>
	/// <release>3.17.6</release>
	DriveTimeThreshold = 59425,

	/// <summary>Drive Time X Bar</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, navigation, driving, routes, map, visualization, mapping, medium, average, median, mean, middle, formula, mathematics</remarks>
	/// <release>3.17.5</release>
	DriveTimeXBar = 59426,

	/// <summary>Driving Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, drive, car, vehicle, route, length, measure, navigate, arrows, destination, traffic</remarks>
	/// <release>3.16.8</release>
	DrivingDistance = 59427,

	/// <summary>Driving Time</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, drive, car, vehicle, route, eta, timer, clock, travel, arrival, traffic</remarks>
	/// <release>3.16.8</release>
	DrivingTime = 59428,

	/// <summary>Drone Fixed Wing</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, propeller plane, airplane, aircraft, long-range drone</remarks>
	/// <release>3.15.2</release>
	DroneFixedWing = 59429,

	/// <summary>Drone Flying Wing</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, airplane, aircraft, long-range drone, glider</remarks>
	/// <release>3.15.2</release>
	DroneFlyingWing = 59430,

	/// <summary>Drone Quadcopter</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, multi-rotor drone, rotary drone, surveillance, aerial photography, hobby, drone inventory, drone hardware</remarks>
	/// <release>3.15.2</release>
	DroneQuadcopter = 59431,

	/// <summary>Drone Quadcopter Top</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, multi-rotor drone, rotary drone, surveillance, aerial photography, hobby, drone hardware, drone fleet</remarks>
	/// <release>3.15.2</release>
	DroneQuadcopterTop = 59432,

	/// <summary>Duplicate</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, copy and paste, multiple</remarks>
	/// <release>1.5</release>
	Duplicate = 59433,

	/// <summary>Edit Attributes</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.0.0, pencil, edit attributes, edit text, edit description</remarks>
	/// <release>3.0.0</release>
	EditAttributes = 59434,

	/// <summary>Edit Geometry</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.23.8, geometry editing, modify, shapes, polygon, edit, correct</remarks>
	/// <release>3.23.8</release>
	EditGeometry = 59435,

	/// <summary>Education</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, graduation, grad cap, school, graduate, classroom, course, academia, academics, learn, lesson, teach</remarks>
	/// <release>1.5</release>
	Education = 59436,

	/// <summary>Effects</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.27.4, objects, ai, sparkle, system, flash, stars, constellations, flashy, shiny, machine learning</remarks>
	/// <release>3.27.1</release>
	Effects = 59437,

	/// <summary>Elevator</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, fire escape, exit, levels, up, down, floors, navigation</remarks>
	/// <release>1.5</release>
	Elevator = 59438,

	/// <summary>Elevator Down</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.22.1, directions, up, down, levels, floors, navigate, navigation, arrow, below</remarks>
	/// <release>3.22.1</release>
	ElevatorDown = 59439,

	/// <summary>Elevator Up</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.22.1, directions, up, down, levels, floors, navigate, navigation, arrow</remarks>
	/// <release>3.22.1</release>
	ElevatorUp = 59440,

	/// <summary>Ellipse</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.20.5, symbols, shapes, single shape, geometry, glyphs, generic</remarks>
	/// <release>3.20.5</release>
	Ellipse = 59441,

	/// <summary>Ellipsis</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, menu, more, ..., …, dot dot dot</remarks>
	/// <release>1.5</release>
	Ellipsis = 59442,

	/// <summary>Ellipsis Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 2.5.4, more options, ellipsis circle, ..., ellipsis, in progress</remarks>
	/// <release>2.5.4</release>
	EllipsisCircle = 59443,

	/// <summary>Email Address</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.9.0, envelope, @, email address, contact, forms</remarks>
	/// <release>3.9.0</release>
	EmailAddress = 59444,

	/// <summary>Embark</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, ship, enter, arrivals, boarding, transportation, navigation</remarks>
	/// <release>1.5</release>
	Embark = 59445,

	/// <summary>Embedded Card</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, related content, embedded card, read next, related articles</remarks>
	/// <release>3.3.0</release>
	EmbeddedCard = 59446,

	/// <summary>Embedded Content</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, iframe, browser</remarks>
	/// <release>1.5</release>
	EmbeddedContent = 59447,

	/// <summary>Embedded Live Content</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, dynamic content, embedded live content, interactive content, dashboard</remarks>
	/// <release>3.3.0</release>
	EmbeddedLiveContent = 59448,

	/// <summary>Employee Id</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.24.9, people, person, badge, security, conference, access, id, identification, person</remarks>
	/// <release>3.24.9</release>
	EmployeeId = 59449,

	/// <summary>Enable Disable Feature Selection</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.2, web editor, layers, show, hide, active, pin, features, toggle</remarks>
	/// <release>3.25.2</release>
	EnableDisableFeatureSelection = 59450,

	/// <summary>End (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, filled</remarks>
	/// <release>1.5</release>
	EndFilled = 59451,

	/// <summary>End</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media</remarks>
	/// <release>1.5</release>
	End = 59452,

	/// <summary>Envelope</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, send, email, contact information</remarks>
	/// <release>1.5</release>
	Envelope = 59453,

	/// <summary>Erase</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, clear</remarks>
	/// <release>1.5</release>
	Erase = 59454,

	/// <summary>Escalator</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, levels, up, down, floors, stairs, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	Escalator = 59455,

	/// <summary>Escalator Down</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.22.1, directions, up, down, levels, floors, navigate, navigation, arrow, below</remarks>
	/// <release>3.22.1</release>
	EscalatorDown = 59456,

	/// <summary>Escalator Up</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.22.1, directions, up, down, levels, floors, navigate, navigation, arrow</remarks>
	/// <release>3.22.1</release>
	EscalatorUp = 59457,

	/// <summary>Event</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.0.0, star, calendar, schedule, book, conference, invite, date, special event</remarks>
	/// <release>3.0.0</release>
	Event = 59458,

	/// <summary>Exclamation Mark Circle (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, invalid, error, broken, filled</remarks>
	/// <release>1.5</release>
	ExclamationMarkCircleFilled = 59459,

	/// <summary>Exclamation Mark Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, invalid, error, broken</remarks>
	/// <release>1.5</release>
	ExclamationMarkCircle = 59460,

	/// <summary>Exclamation Mark Triangle (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, warning, alert, filled</remarks>
	/// <release>1.5</release>
	ExclamationMarkTriangleFilled = 59461,

	/// <summary>Exclamation Mark Triangle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, warning, alert</remarks>
	/// <release>1.5</release>
	ExclamationMarkTriangle = 59462,

	/// <summary>Exclamation Point (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.29.0, symbols, sign, text, type, attribution, warning, invalid, high priority, important, error</remarks>
	/// <release>3.29.0</release>
	ExclamationPointFilled = 59463,

	/// <summary>Exclamation Point</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.29.0, symbols, sign, text, type, attribution, warning, invalid, high priority, important, error</remarks>
	/// <release>3.29.0</release>
	ExclamationPoint = 59464,

	/// <summary>Exit Highway Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	ExitHighwayLeft = 59465,

	/// <summary>Exit Highway Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, arrow</remarks>
	/// <release>1.5</release>
	ExitHighwayRight = 59466,

	/// <summary>Expand</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, full screen, enlarge</remarks>
	/// <release>1.5</release>
	Expand = 59467,

	/// <summary>Explore</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.9, gis, compass, needle, directions, circle, rotation, navigation, gps, location, tracking, cardinal, orientation, compass rose, mapping, cartography, destination, navigate</remarks>
	/// <release>3.17.9</release>
	Explore = 59468,

	/// <summary>Export</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, upload, deliver, send</remarks>
	/// <release>1.5</release>
	Export = 59469,

	/// <summary>Expression Defined Color</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.23.5, text, text, color, bracket, swatch, letter, font</remarks>
	/// <release>3.23.5</release>
	ExpressionDefinedColor = 59470,

	/// <summary>Extend Trim</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.23.8, geometry editing, continue, stop, lines, edges, points, trimming, extending</remarks>
	/// <release>3.23.8</release>
	ExtendTrim = 59471,

	/// <summary>Extent</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, zoom out, frame, set, full screen, borders, boundaries, bounding box, corners, edges, crop, view</remarks>
	/// <release>1.5</release>
	Extent = 59472,

	/// <summary>Extent Filter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, extent filter, filter by extent, funnel</remarks>
	/// <release>3.25.2</release>
	ExtentFilter = 59473,

	/// <summary>Eyedropper</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, color-picker</remarks>
	/// <release>1.5</release>
	Eyedropper = 59474,

	/// <summary>Face Id</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.9, objects, person, identification, ID, identify, security, private, identity, personal, access, photo</remarks>
	/// <release>3.20.9</release>
	FaceId = 59475,

	/// <summary>Feature Details</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, feature, details</remarks>
	/// <release>1.5</release>
	FeatureDetails = 59476,

	/// <summary>Feature Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.2, layers, feature layer, map pin, gis</remarks>
	/// <release>2.7.0</release>
	FeatureLayer = 59477,

	/// <summary>File</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, document, blank</remarks>
	/// <release>1.5</release>
	File = 59478,

	/// <summary>File Archive</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, document, record, history, legacy</remarks>
	/// <release>1.5</release>
	FileArchive = 59479,

	/// <summary>File Cad</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.16.0, files, document, 3d, design, cad file</remarks>
	/// <release>1.5</release>
	FileCad = 59480,

	/// <summary>File Code</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, document, html, css, js, java, javascript, python, developer, build, programmer, back end, front end, index, ruby, script</remarks>
	/// <release>1.5</release>
	FileCode = 59481,

	/// <summary>File Csv</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.16.0, files, document, excel spreadsheet, table, csv file</remarks>
	/// <release>1.5</release>
	FileCsv = 59482,

	/// <summary>File Data</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.16.0, files, document, database, file type, file format, data sheet</remarks>
	/// <release>3.16.0</release>
	FileData = 59483,

	/// <summary>File Ecd</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.18.7, files, ecd, esri, classifier, definition, format, extension</remarks>
	/// <release>3.18.7</release>
	FileEcd = 59484,

	/// <summary>File Excel</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, document, spreadsheet, excel, table, excel file</remarks>
	/// <release>1.5</release>
	FileExcel = 59485,

	/// <summary>File Gpx</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.16.0, files, document, gpx file</remarks>
	/// <release>1.5</release>
	FileGpx = 59486,

	/// <summary>File Image</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, photograph, picture, gif, png, jpeg, jpg, tiff</remarks>
	/// <release>1.5</release>
	FileImage = 59487,

	/// <summary>File Kml</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.16.0, files, keyhole markup language, file type, file format</remarks>
	/// <release>3.16.0</release>
	FileKml = 59488,

	/// <summary>File Magnifying Glass</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, search documents, search files, review, find files, find documents, locate files, locate documents, analyze, investigate file, investigate document, case file, case study, research</remarks>
	/// <release>1.5</release>
	FileMagnifyingGlass = 59489,

	/// <summary>File Pdf</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, acrobat, adobe, pdf file, pdf document</remarks>
	/// <release>1.5</release>
	FilePdf = 59490,

	/// <summary>File Pdf Plus</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, new pdf file, create pdf file, new pdf document, create pdf document, acrobat, adobe pdf</remarks>
	/// <release>1.5</release>
	FilePdfPlus = 59491,

	/// <summary>File Pitemx</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, file type, format, developer</remarks>
	/// <release>1.5</release>
	FilePitemx = 59492,

	/// <summary>File Ppt</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.20.3, files, ppt, esri, definition, format, extension, collection, presentations, .pptx, powerpoint, microsoft, file type</remarks>
	/// <release>3.20.3</release>
	FilePpt = 59493,

	/// <summary>File Report</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, document, csv, table, excel</remarks>
	/// <release>1.5</release>
	FileReport = 59494,

	/// <summary>File Shape</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.16.0, files, file type, file format, vector file, shapefile, vector data</remarks>
	/// <release>3.16.0</release>
	FileShape = 59495,

	/// <summary>File Sound</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, audio, music, mp3</remarks>
	/// <release>1.5</release>
	FileSound = 59496,

	/// <summary>File Sqlite</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.20.3, files, sqlite, feather, esri, definition, format, extension, collection, file type</remarks>
	/// <release>3.20.3</release>
	FileSqlite = 59497,

	/// <summary>File Text</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, document, txt, note, word, rtf, write, text file</remarks>
	/// <release>1.5</release>
	FileText = 59498,

	/// <summary>File User</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.24.9, people, project manager, file, administrator, page, paper, item</remarks>
	/// <release>3.24.9</release>
	FileUser = 59499,

	/// <summary>File Video</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, motion, gif, mp4, avi, quick time player</remarks>
	/// <release>1.5</release>
	FileVideo = 59500,

	/// <summary>File Word</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, word document, text, write, note, documentation, word file</remarks>
	/// <release>1.5</release>
	FileWord = 59501,

	/// <summary>File Xml</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.27.5, files, xml, extensive markup language, file format, file type</remarks>
	/// <release>3.27.5</release>
	FileXml = 59502,

	/// <summary>File Zip</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, compressed file, archive, zip file</remarks>
	/// <release>1.5</release>
	FileZip = 59503,

	/// <summary>Files</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, documents, multiple</remarks>
	/// <release>1.5</release>
	Files = 59504,

	/// <summary>Files Csv Collection</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.20.3, files, csv, esri, definition, format, extension, collection, file type</remarks>
	/// <release>3.20.3</release>
	FilesCsvCollection = 59505,

	/// <summary>Filter</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, funnel</remarks>
	/// <release>1.5</release>
	Filter = 59506,

	/// <summary>Filter Expand</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.25.8, knowledge graph, filters, expanding, link chart, data model</remarks>
	/// <release>3.25.8</release>
	FilterExpand = 59507,

	/// <summary>Fingerprint</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: generic, 3.17.0, biometric, identification, identity, password, protected, private, unlock, access</remarks>
	/// <release>3.17.0</release>
	Fingerprint = 59508,

	/// <summary>Flag (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.29.1, objects, signal, flag, sign, important, warning, alert, caution, filled</remarks>
	/// <release>3.29.1</release>
	FlagFilled = 59509,

	/// <summary>Flag</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.29.1, objects, signal, flag, sign, important, warning, alert, caution</remarks>
	/// <release>3.29.1</release>
	Flag = 59510,

	/// <summary>Flag Slash</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.29.1, objects, flag, cancel, stop, slash, signal, remove, important, alert</remarks>
	/// <release>3.29.1</release>
	FlagSlash = 59511,

	/// <summary>Flash</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, light, lightning bolt, lightning, weather, severe weather, sky, forecast, thunder, stormy, highlight, flashing</remarks>
	/// <release>1.5</release>
	Flash = 59512,

	/// <summary>Flip</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.6, generic, arrows, dotted line, transform, align</remarks>
	/// <release>3.19.6</release>
	Flip = 59513,

	/// <summary>Flip Vertical</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, flipping, opposite, arrows, dotted lines, transforming, aligning</remarks>
	/// <release>3.25.2</release>
	FlipVertical = 59514,

	/// <summary>Floor Plan</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, blueprint, building, indoors, indoor navigation, floor plan, stairs, level, rooms, house, home, apartment, office layout</remarks>
	/// <release>3.0.0</release>
	FloorPlan = 59515,

	/// <summary>Fog</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, cloudy, weather, sky, forecast, temperature, environment, nature, precipitation, wind, stormy, gloomy, overcast, coastal</remarks>
	/// <release>3.17.6</release>
	Fog = 59516,

	/// <summary>Folder (Filled)</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.26.3, files, folders, collapsed, directory, filled</remarks>
	/// <release>3.26.3</release>
	FolderFilled = 59517,

	/// <summary>Folder</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, directory, collapsed</remarks>
	/// <release>1.5</release>
	Folder = 59518,

	/// <summary>Folder Archive</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, directory, storage, record, history, legacy</remarks>
	/// <release>1.5</release>
	FolderArchive = 59519,

	/// <summary>Folder Magnifying Glass</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.26.8, files, find files, search files, locate documents, folder, research</remarks>
	/// <release>3.26.8</release>
	FolderMagnifyingGlass = 59520,

	/// <summary>Folder Move</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, directory, arrow, go to, relocate, forward</remarks>
	/// <release>1.5</release>
	FolderMove = 59521,

	/// <summary>Folder New</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, new directory, create directory, add directory, new folder, create folder, add folder</remarks>
	/// <release>1.5</release>
	FolderNew = 59522,

	/// <summary>Folder Open (Filled)</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 3.26.3, files, open folder, open state, open directory, browse, expanded, filled</remarks>
	/// <release>3.26.3</release>
	FolderOpenFilled = 59523,

	/// <summary>Folder Open</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, open folder, open state, open directory, browse, expanded</remarks>
	/// <release>1.5</release>
	FolderOpen = 59524,

	/// <summary>Folder Plus</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, new directory, create directory, add directory, new folder, create folder, add folder</remarks>
	/// <release>1.5</release>
	FolderPlus = 59525,

	/// <summary>Folder Star</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 1.5.0, files, favorite directory, favorite folder, star directory, star folder</remarks>
	/// <release>1.5</release>
	FolderStar = 59526,

	/// <summary>Folder Video</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.5, gis, folder, video, play, source, store</remarks>
	/// <release>3.25.5</release>
	FolderVideo = 59527,

	/// <summary>Folders</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.2, objects, files, directory, storage, system, organize, collapsed, layers, stack, order</remarks>
	/// <release>3.18.2</release>
	Folders = 59528,

	/// <summary>Follow</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, navigation, tracking</remarks>
	/// <release>1.5</release>
	Follow = 59529,

	/// <summary>Follow Pause</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, navigation, tracking</remarks>
	/// <release>1.5</release>
	FollowPause = 59530,

	/// <summary>Follow Play</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, navigation, tracking</remarks>
	/// <release>1.5</release>
	FollowPlay = 59531,

	/// <summary>Footer</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.10.0, about the author, featured, contact information, credits</remarks>
	/// <release>3.10.0</release>
	Footer = 59532,

	/// <summary>Footprint</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.3, overlap, map, polygon, selection</remarks>
	/// <release>2.5.3</release>
	Footprint = 59533,

	/// <summary>Force Directed Link Chart Layout</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial data, spatial analysis, data model</remarks>
	/// <release>3.23.6</release>
	ForceDirectedLinkChartLayout = 59534,

	/// <summary>Fork Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn left, split, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	ForkLeft = 59535,

	/// <summary>Fork Middle</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, straight, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	ForkMiddle = 59536,

	/// <summary>Fork Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn right, split, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	ForkRight = 59537,

	/// <summary>Form Dropdown</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.17.8, forms, list, form field, items, form elements</remarks>
	/// <release>3.17.8</release>
	FormDropdown = 59538,

	/// <summary>Form Elements</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.0.0, forms, web survey elements, form elements, form fields</remarks>
	/// <release>3.0.0-beta.6</release>
	FormElements = 59539,

	/// <summary>Form Field</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.0.0, forms, form field, input</remarks>
	/// <release>3.0.0-beta.6</release>
	FormField = 59540,

	/// <summary>Form Field Multiline</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.0.0, forms, form field multiline, input, form field paragraph</remarks>
	/// <release>3.0.0-beta.6</release>
	FormFieldMultiline = 59541,

	/// <summary>Form Field Off</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.16.6, forms, input, text box, none, empty, no text, text off, no label, label off</remarks>
	/// <release>3.16.6</release>
	FormFieldOff = 59542,

	/// <summary>Forward (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, filled</remarks>
	/// <release>1.5</release>
	ForwardFilled = 59543,

	/// <summary>Forward</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media</remarks>
	/// <release>1.5</release>
	Forward = 59544,

	/// <summary>Frame Export</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.26.5, media, video, film, arrow, clip, tape, extract, mp4, file, save, motion, play</remarks>
	/// <release>3.26.5</release>
	FrameExport = 59545,

	/// <summary>Freehand</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, draw, polygon, pencil, lasso, squiggle, doodle</remarks>
	/// <release>1.5</release>
	Freehand = 59546,

	/// <summary>Frown</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.0, generic, sad, dissatisfied, dissatisfaction, unhappy, face, dislike, emoji</remarks>
	/// <release>3.16.0</release>
	Frown = 59547,

	/// <summary>Full Screen</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.16.6, windows, fit to screen, fill screen, enlarge, expand, present, arrows</remarks>
	/// <release>3.16.6</release>
	FullScreen = 59548,

	/// <summary>Full Screen Exit</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, return, default, windowed, window mode, extent, view</remarks>
	/// <release>1.5</release>
	FullScreenExit = 59549,

	/// <summary>Function</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: symbol, character, text, equations, linear equations, algebra, mathematics, graph, notation, value, formula, 3.8.1</remarks>
	/// <release>3.8.1</release>
	Function = 59550,

	/// <summary>Function Editor</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.9, GIS, fx, edit, raster, modify</remarks>
	/// <release>3.21.9</release>
	FunctionEditor = 59551,

	/// <summary>Gallery</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.10.0, mosaic, photography, images, imagery, masonry, photo grid</remarks>
	/// <release>3.10.0</release>
	Gallery = 59552,

	/// <summary>Gamma</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, symbol, greek character, gamma rays</remarks>
	/// <release>1.5</release>
	Gamma = 59553,

	/// <summary>Gauge</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, statistic, monitor, threshold, limit</remarks>
	/// <release>1.5</release>
	Gauge = 59554,

	/// <summary>Gauge Summary</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, statistic, monitor, threshold, limit, number</remarks>
	/// <release>1.5</release>
	GaugeSummary = 59555,

	/// <summary>Gear</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, settings, preferences, cog, options</remarks>
	/// <release>1.5</release>
	Gear = 59556,

	/// <summary>Geoanalytics Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, analytics, servers, connected, connections, networks, paths</remarks>
	/// <release>3.20.7</release>
	GeoanalyticsServer = 59557,

	/// <summary>Geoevent Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, events, time, date, watch</remarks>
	/// <release>3.20.7</release>
	GeoeventServer = 59558,

	/// <summary>Geographic Link Chart Layout</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, map, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, layout</remarks>
	/// <release>3.20.6</release>
	GeographicLinkChartLayout = 59559,

	/// <summary>Geonet</summary>
	/// <remarks>Category: Social Media<br/>
	/// Alias: 1.5.0, social-media, share, social</remarks>
	/// <release>1.5</release>
	Geonet = 59560,

	/// <summary>Geonet Question</summary>
	/// <remarks>Category: Social Media<br/>
	/// Alias: 1.5.0, social-media, ?, social</remarks>
	/// <release>1.5</release>
	GeonetQuestion = 59561,

	/// <summary>Gis Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, servers, layers, connected, connections, networks</remarks>
	/// <release>3.20.7</release>
	GisServer = 59562,

	/// <summary>Globe</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, world</remarks>
	/// <release>1.5</release>
	Globe = 59563,

	/// <summary>Gps Off</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, locate, current location, tracking</remarks>
	/// <release>1.5</release>
	GpsOff = 59564,

	/// <summary>Gps On (Filled)</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, locate, current location, tracking, filled</remarks>
	/// <release>1.5</release>
	GpsOnFilled = 59565,

	/// <summary>Gps On</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, locate, current location, tracking</remarks>
	/// <release>1.5</release>
	GpsOn = 59566,

	/// <summary>Graph Axis</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.21.1, charts and graphs, axis, chart, x, y, data, diagram, visualization</remarks>
	/// <release>3.21.1</release>
	GraphAxis = 59567,

	/// <summary>Graph Bar 100 Stacked</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.0.0, graph bar 100 stacked, bar chart, diagram, visualization, charts and graphs</remarks>
	/// <release>3.0.0-beta.3</release>
	GraphBar100Stacked = 59568,

	/// <summary>Graph Bar</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, bars, bar chart, diagram, visualization</remarks>
	/// <release>1.5</release>
	GraphBar = 59569,

	/// <summary>Graph Bar Side By Side</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.0.0, graph bar side by side, charts-and-graphs, bars, bar chart, diagram, visualization</remarks>
	/// <release>3.0.0-beta.3</release>
	GraphBarSideBySide = 59570,

	/// <summary>Graph Bar Stacked</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.0.0, graph bar stacked, charts-and-graphs, bars, bar chart, diagram, visualization, stacked</remarks>
	/// <release>3.0.0-beta.3</release>
	GraphBarStacked = 59571,

	/// <summary>Graph Box Mean Lines</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.26.1, charts and graphs, box, plot, version, management, lines, branch, edit, rectangle, mean</remarks>
	/// <release>3.26.1</release>
	GraphBoxMeanLines = 59572,

	/// <summary>Graph Guides</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.21.1, charts and graphs, guides, chart, guide, data, diagram, visualization</remarks>
	/// <release>3.21.1</release>
	GraphGuides = 59573,

	/// <summary>Graph Histogram</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, history, bars, bar chart, diagram, visualization</remarks>
	/// <release>1.5</release>
	GraphHistogram = 59574,

	/// <summary>Graph Line Series</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.21.1, charts and graphs, lines, chart, data, diagram, visualization</remarks>
	/// <release>3.21.1</release>
	GraphLineSeries = 59575,

	/// <summary>Graph Moving Average</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, bars, bar chart, diagram, visualization, average, line chart</remarks>
	/// <release>1.5</release>
	GraphMovingAverage = 59576,

	/// <summary>Graph Scatter Plot</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, points, data</remarks>
	/// <release>1.5</release>
	GraphScatterPlot = 59577,

	/// <summary>Graph Time Series</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, line graph, line chart, monitor, sequence, chronological, progress, record, history</remarks>
	/// <release>1.5</release>
	GraphTimeSeries = 59578,

	/// <summary>Grid</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, generic, organized, boxes, squares, cube, guide</remarks>
	/// <release>1.5</release>
	Grid = 59579,

	/// <summary>Grid Diamond</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.19.0, gis, shapes, map, area, angles, pattern, tile, square</remarks>
	/// <release>3.19.0</release>
	GridDiamond = 59580,

	/// <summary>Grid Hexagon</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.19.0, gis, shapes, map, area, angles, pattern, tile, square</remarks>
	/// <release>3.19.0</release>
	GridHexagon = 59581,

	/// <summary>Grid Triangle</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.19.0, gis, shapes, map, area, angles, pattern, tile, square</remarks>
	/// <release>3.19.0</release>
	GridTriangle = 59582,

	/// <summary>Grid Unit</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, grid</remarks>
	/// <release>3.17.1</release>
	GridUnit = 59583,

	/// <summary>Ground Control Point</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, site scan, area, drone, flight, path, track, pattern</remarks>
	/// <release>3.25.2</release>
	GroundControlPoint = 59584,

	/// <summary>Group</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people</remarks>
	/// <release>1.5</release>
	Group = 59585,

	/// <summary>Group Form</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.0.0, forms, group form field, group form elements</remarks>
	/// <release>3.0.0-beta.6</release>
	GroupForm = 59586,

	/// <summary>Group Form Plus</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.14.1, forms, group form plus, add group, create group</remarks>
	/// <release>3.14.1</release>
	GroupFormPlus = 59587,

	/// <summary>Group Items</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.17.4, group, shapes, items, artboard</remarks>
	/// <release>3.17.4</release>
	GroupItems = 59588,

	/// <summary>Group Layers</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.9, layers, layer stack, on, set</remarks>
	/// <release>3.25.9</release>
	GroupLayers = 59589,

	/// <summary>Group Layout Elements</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.17.4, group, shapes, items, artboard</remarks>
	/// <release>3.17.4</release>
	GroupLayoutElements = 59590,

	/// <summary>Group X</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.0.0, forms, delete group, group x, remove group, clear group</remarks>
	/// <release>3.0.0-beta.6</release>
	GroupX = 59591,

	/// <summary>Hamburger</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, menu, options, dropdown menu, more</remarks>
	/// <release>1.5</release>
	Hamburger = 59592,

	/// <summary>Hammer</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, app-studio, geoprocessing</remarks>
	/// <release>1.5</release>
	Hammer = 59593,

	/// <summary>Handle Vertical</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.6.2, generic, more, ..., dot dot dot, …, ellipsis, handle, options, settings, dropdown menu</remarks>
	/// <release>1.6.2</release>
	HandleVertical = 59594,

	/// <summary>Heading</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.3.0, bold text, large text, header</remarks>
	/// <release>3.3.0</release>
	Heading = 59595,

	/// <summary>Heading Layout</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.21.7, text, heading, layout, title, words, list, bold text, large text</remarks>
	/// <release>3.21.7</release>
	HeadingLayout = 59596,

	/// <summary>Heading Rtl</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.7.0, bold text, large text, header</remarks>
	/// <release>3.7.0</release>
	HeadingRtl = 59597,

	/// <summary>Headset</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, headphones, customer, service, representative, support</remarks>
	/// <release>1.5</release>
	Headset = 59598,

	/// <summary>Heart (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.9, generic, shape, love, favorite, valentine, gift, like, filled</remarks>
	/// <release>3.19.9</release>
	HeartFilled = 59599,

	/// <summary>Heart</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.9, generic, shape, love, favorite, valentine, gift, like</remarks>
	/// <release>3.19.9</release>
	Heart = 59600,

	/// <summary>Heat Chart</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, heat map, charts and graphs, graphs, two-dimensional, data sets, analysis, tabular, value</remarks>
	/// <release>1.5</release>
	HeatChart = 59601,

	/// <summary>Heavy Rain</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, windy, stormy, cloudy, severe weather</remarks>
	/// <release>3.17.6</release>
	HeavyRain = 59602,

	/// <summary>Heavy Snow</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, windy, stormy, snowy, severe weather, freezing</remarks>
	/// <release>3.17.6</release>
	HeavySnow = 59603,

	/// <summary>Hexagon</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.25.1, symbols, shapes, single shape, glyphs, generic, geometry</remarks>
	/// <release>3.25.1</release>
	Hexagon = 59604,

	/// <summary>Hexagon 2</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, single shape, geometry</remarks>
	/// <release>3.28.8</release>
	Hexagon2 = 59605,

	/// <summary>Hexagon 2 Inset Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, filled, bold</remarks>
	/// <release>3.28.8</release>
	Hexagon2InsetLarge = 59606,

	/// <summary>Hexagon 2 Inset Medium</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, hexagon, bold, filled</remarks>
	/// <release>3.28.8</release>
	Hexagon2InsetMedium = 59607,

	/// <summary>Hexagon 2 Inset Small</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, hexagon</remarks>
	/// <release>3.28.8</release>
	Hexagon2InsetSmall = 59608,

	/// <summary>Hexagon Inset Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, hexagon, geometry</remarks>
	/// <release>3.28.8</release>
	HexagonInsetLarge = 59609,

	/// <summary>Hexagon Inset Medium</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, hexagon, bold</remarks>
	/// <release>3.28.8</release>
	HexagonInsetMedium = 59610,

	/// <summary>Hexagon Inset Small</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, hexagon, filled</remarks>
	/// <release>3.28.8</release>
	HexagonInsetSmall = 59611,

	/// <summary>Hide Derived Value</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.25.2, forms, online model builder, hidden, hiding, eye, display, arrow, data, values</remarks>
	/// <release>3.25.2</release>
	HideDerivedValue = 59612,

	/// <summary>Hide Empty</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, empty, table, field, eye, view, not visible, hidden, unhide, invisible, not shown, insights</remarks>
	/// <release>1.5</release>
	HideEmpty = 59613,

	/// <summary>Hide Layers</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.24.0, layers, layer, hide, hidden, stacked, multiple, eye, view, cover</remarks>
	/// <release>3.24.0</release>
	HideLayers = 59614,

	/// <summary>Hide Parameters</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.25.2, forms, online model builder, hidden, eye, hiding, variable, display</remarks>
	/// <release>3.25.2</release>
	HideParameters = 59615,

	/// <summary>Hierarchical Link Chart Layout</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial data, spatial analysis, data model, direction, levels</remarks>
	/// <release>3.23.6</release>
	HierarchicalLinkChartLayout = 59616,

	/// <summary>Highlighter</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, drawing, tool, instrument, marker, sharpie</remarks>
	/// <release>3.16.6</release>
	Highlighter = 59617,

	/// <summary>Highlighter Tip</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, drawing, tool, instrument, marker, sharpie</remarks>
	/// <release>3.16.6</release>
	HighlighterTip = 59618,

	/// <summary>Highway Change</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, merge, switch, change lanes, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	HighwayChange = 59619,

	/// <summary>Highway Change Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, merge, switch, change lanes, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	HighwayChangeRight = 59620,

	/// <summary>Home</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, index, navigation, start, homepage</remarks>
	/// <release>1.5</release>
	Home = 59621,

	/// <summary>Horizontal Distribute</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.2, boxes, UI, interface, align, line up, middle, center, central alignment</remarks>
	/// <release>3.17.2</release>
	HorizontalDistribute = 59622,

	/// <summary>Hourglass Active</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, time</remarks>
	/// <release>1.5</release>
	HourglassActive = 59623,

	/// <summary>Hourglass Expired</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, time</remarks>
	/// <release>1.5</release>
	HourglassExpired = 59624,

	/// <summary>Image</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, photo</remarks>
	/// <release>1.5</release>
	Image = 59625,

	/// <summary>Image Chips</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, image, geoai, chips</remarks>
	/// <release>3.17.1</release>
	ImageChips = 59626,

	/// <summary>Image Magnifying Glass</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.24.7, media, photo, zoom, image search, picture, photograph, imagery, locate, analyze, inspect</remarks>
	/// <release>3.24.7</release>
	ImageMagnifyingGlass = 59627,

	/// <summary>Image Mensuration</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.1, measure, image size, dimensions, width, height, resolution, dpi, ppi</remarks>
	/// <release>1.6.1</release>
	ImageMensuration = 59628,

	/// <summary>Image Pin</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.16.0, media, photo, picture, photograph, imagery, location, feature, gis, georeferenced, map pin</remarks>
	/// <release>3.16.0</release>
	ImagePin = 59629,

	/// <summary>Image Plus</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.15.3, Media, add image, attach image, attach photo, add photo, insert photo, insert image, upload image</remarks>
	/// <release>3.15.3</release>
	ImagePlus = 59630,

	/// <summary>Image Segmentation</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.4, image segmentation, geoprocessing, image classification, group images, pixels</remarks>
	/// <release>2.5.4</release>
	ImageSegmentation = 59631,

	/// <summary>Image Space</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.4, workmode, image space, workspace, segment, measure, grid</remarks>
	/// <release>2.5.4</release>
	ImageSpace = 59632,

	/// <summary>Image Unit</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, image</remarks>
	/// <release>3.17.1</release>
	ImageUnit = 59633,

	/// <summary>Images</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, picture, media, photo</remarks>
	/// <release>1.5</release>
	Images = 59634,

	/// <summary>Import</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.14.5, arrows, input, inbox, inside, include, collect, pull, drop, deposit, insert</remarks>
	/// <release>3.14.5</release>
	Import = 59635,

	/// <summary>Inbox</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.6.0, mail, email, incoming, arrow</remarks>
	/// <release>3.6.0</release>
	Inbox = 59636,

	/// <summary>Increase Link Chart Symbol Size</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, circle, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale</remarks>
	/// <release>3.20.6</release>
	IncreaseLinkChartSymbolSize = 59637,

	/// <summary>Indicator</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Indicator = 59638,

	/// <summary>Infographic</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, shapes, visualization</remarks>
	/// <release>1.5</release>
	Infographic = 59639,

	/// <summary>Information (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, about, help, tooltip, filled</remarks>
	/// <release>1.5</release>
	InformationFilled = 59640,

	/// <summary>Information</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, about, help, tooltip</remarks>
	/// <release>1.5</release>
	Information = 59641,

	/// <summary>Information Letter</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.9.0, information letter, information kiosk, details, help, about</remarks>
	/// <release>3.9.0</release>
	InformationLetter = 59642,

	/// <summary>Initiative</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.1, objects, summit, mountain, flag, goals, tent, camp, achievement, target, objectives, accomplishment, climb, plan, project</remarks>
	/// <release>3.18.1</release>
	Initiative = 59643,

	/// <summary>Insets</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.18.8, windows, insets, square, map, section, bracket, column, cropped, focus, selection</remarks>
	/// <release>3.18.8</release>
	Insets = 59644,

	/// <summary>Inspection</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, paper, certification, approval, award, rating, notice, permit, certificate</remarks>
	/// <release>3.15.2</release>
	Inspection = 59645,

	/// <summary>Integer</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 2.5.3, datatype, letters, text, positive number, negative number, plus or minus</remarks>
	/// <release>2.5.3</release>
	Integer = 59646,

	/// <summary>Investigation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, knowledge graph, briefcase, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model</remarks>
	/// <release>3.25.2</release>
	Investigation = 59647,

	/// <summary>Italicize</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Italicize = 59648,

	/// <summary>Joined View Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.3, layers, join, data, information, combine, multiple</remarks>
	/// <release>3.22.3</release>
	JoinedViewLayer = 59649,

	/// <summary>Justify</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.29.6, lists, alignment, typography, paragraph, type, body text, format, justification</remarks>
	/// <release>3.29.6</release>
	Justify = 59650,

	/// <summary>Key</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, access, permission, admin</remarks>
	/// <release>1.5</release>
	Key = 59651,

	/// <summary>Keyboard</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.5, objects, keyboard, keys, desktop, office, desk</remarks>
	/// <release>3.18.5</release>
	Keyboard = 59652,

	/// <summary>Keypad</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 2.5.5, calculator, numbers, digits, buttons, security code, numerals, passcode, password, PIN</remarks>
	/// <release>2.5.5</release>
	Keypad = 59653,

	/// <summary>Knowledge Graph</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, link</remarks>
	/// <release>3.20.6</release>
	KnowledgeGraph = 59654,

	/// <summary>Knowledge Graph Dashboard</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale, monitor, link</remarks>
	/// <release>3.20.6</release>
	KnowledgeGraphDashboard = 59655,

	/// <summary>Knowledge Graph Data Model</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, database canister, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale, gear, data, link</remarks>
	/// <release>3.20.6</release>
	KnowledgeGraphDataModel = 59656,

	/// <summary>Knowledge Graph Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, database, storage, stored, technology, data, link charts, connection, data source</remarks>
	/// <release>3.28.3</release>
	KnowledgeGraphDataStore = 59657,

	/// <summary>Knowledge Graph Export</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale, link, up, arrow</remarks>
	/// <release>3.20.6</release>
	KnowledgeGraphExport = 59658,

	/// <summary>Knowledge Graph Import</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale, link, down, arrow</remarks>
	/// <release>3.20.6</release>
	KnowledgeGraphImport = 59659,

	/// <summary>Knowledge Graph New</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale, sun, link</remarks>
	/// <release>3.20.6</release>
	KnowledgeGraphNew = 59660,

	/// <summary>Knowledge Layer</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, layer type, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale</remarks>
	/// <release>3.20.6</release>
	KnowledgeLayer = 59661,

	/// <summary>Knowledge Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, graph, softwares, products, link, relationships, connections, network</remarks>
	/// <release>3.20.7</release>
	KnowledgeServer = 59662,

	/// <summary>Knowledge Studio</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 3.25.2, brand, knowledge graph, product, logo, esri</remarks>
	/// <release>3.25.2</release>
	KnowledgeStudio = 59663,

	/// <summary>Label</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, tag</remarks>
	/// <release>1.5</release>
	Label = 59664,

	/// <summary>Label Off</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.6, objects, turn off, hide, remove, labels, disappear</remarks>
	/// <release>3.20.6</release>
	LabelOff = 59665,

	/// <summary>Language</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.8, generic, communication, translation, word, dictionary, speech</remarks>
	/// <release>3.17.8</release>
	Language = 59666,

	/// <summary>Language Translate</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.8, communication, interchange, lexicon, conversation, word, countries</remarks>
	/// <release>3.17.8</release>
	LanguageTranslate = 59667,

	/// <summary>Lasso</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, selection, freeform</remarks>
	/// <release>1.5</release>
	Lasso = 59668,

	/// <summary>Lasso Select</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.17.0, marquee, draw, freehand, freeform, selection</remarks>
	/// <release>3.17.0</release>
	LassoSelect = 59669,

	/// <summary>Launch 2</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.25.2, arrows, raster function template, open in new window, open, external link, expand, launching</remarks>
	/// <release>3.25.2</release>
	Launch2 = 59670,

	/// <summary>Launch</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, open in new window, open, external link, expand</remarks>
	/// <release>1.5</release>
	Launch = 59671,

	/// <summary>Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, gis, single layer</remarks>
	/// <release>1.5</release>
	Layer = 59672,

	/// <summary>Layer Basemap</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers</remarks>
	/// <release>1.5</release>
	LayerBasemap = 59673,

	/// <summary>Layer Broken</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, broken</remarks>
	/// <release>1.5</release>
	LayerBroken = 59674,

	/// <summary>Layer Connection</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.29.2, layers, plug, top, connection, network, properties</remarks>
	/// <release>3.29.2</release>
	LayerConnection = 59675,

	/// <summary>Layer Filter</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, filter</remarks>
	/// <release>1.5</release>
	LayerFilter = 59676,

	/// <summary>Layer Graphics</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, graphic</remarks>
	/// <release>1.5</release>
	LayerGraphics = 59677,

	/// <summary>Layer Hide</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, hidden, invisible, not visible, not shown, eye</remarks>
	/// <release>1.5</release>
	LayerHide = 59678,

	/// <summary>Layer Kml</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, kml</remarks>
	/// <release>1.5</release>
	LayerKml = 59679,

	/// <summary>Layer Line</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, line, feature layer</remarks>
	/// <release>1.5</release>
	LayerLine = 59680,

	/// <summary>Layer Line Service</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, line, service, feature layer</remarks>
	/// <release>1.5</release>
	LayerLineService = 59681,

	/// <summary>Layer Map</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers</remarks>
	/// <release>1.5</release>
	LayerMap = 59682,

	/// <summary>Layer Map Service</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, map, service</remarks>
	/// <release>1.5</release>
	LayerMapService = 59683,

	/// <summary>Layer Points</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, feature layer</remarks>
	/// <release>1.5</release>
	LayerPoints = 59684,

	/// <summary>Layer Polygon</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, feature layer</remarks>
	/// <release>1.5</release>
	LayerPolygon = 59685,

	/// <summary>Layer Polygon Service</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, service, feature layer</remarks>
	/// <release>1.5</release>
	LayerPolygonService = 59686,

	/// <summary>Layer Service</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.14.5, layers, service, feature layer</remarks>
	/// <release>3.14.5</release>
	LayerService = 59687,

	/// <summary>Layer Settings</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.2, layers, web editor, edits, tools, options</remarks>
	/// <release>3.25.2</release>
	LayerSettings = 59688,

	/// <summary>Layer Zoom To</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, magnifying glass, plus, gis</remarks>
	/// <release>1.5</release>
	LayerZoomTo = 59689,

	/// <summary>Layers (Filled)</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.32.0, layers, arcgis, filled</remarks>
	/// <release>3.32.0</release>
	LayersFilled = 59690,

	/// <summary>Layers</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers</remarks>
	/// <release>1.5</release>
	Layers = 59691,

	/// <summary>Layers Editable</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.0.0, layers editable, pencil, customizable layers, read and write layers</remarks>
	/// <release>3.0.0-beta.6</release>
	LayersEditable = 59692,

	/// <summary>Layers Reference</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.0.0, layers reference, reference layers, book layer, authoritative layers</remarks>
	/// <release>3.0.0-beta.6</release>
	LayersReference = 59693,

	/// <summary>Layout Compact</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.0, generic, boxes, spacing, layout, format, compact, minimize</remarks>
	/// <release>3.25.0</release>
	LayoutCompact = 59694,

	/// <summary>Layout Horizontal</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, column, row, text, items, organize, resize, card, widget, rotate, switch, flip, sideways, left to right</remarks>
	/// <release>1.5</release>
	LayoutHorizontal = 59695,

	/// <summary>Layout Spacious</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.0, generic, boxes, spacing, layout, format, spacious</remarks>
	/// <release>3.25.0</release>
	LayoutSpacious = 59696,

	/// <summary>Layout Vertical</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, column, row, text, items, organize, resize, card, widget, rotate, switch, flip, up and down, top to bottom</remarks>
	/// <release>1.5</release>
	LayoutVertical = 59697,

	/// <summary>Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn left, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	Left = 59698,

	/// <summary>Left Align</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.17.7, text, typography, alignment, paragraph, type, body text, format, justification, justify</remarks>
	/// <release>3.17.7</release>
	LeftAlign = 59699,

	/// <summary>Left Edge</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, left edge, previous, left side</remarks>
	/// <release>3.7.0</release>
	LeftEdge = 59700,

	/// <summary>Left Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	LeftLeft = 59701,

	/// <summary>Left Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	LeftRight = 59702,

	/// <summary>Legend</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, key, symbols, shapes, items, map, point symbols</remarks>
	/// <release>1.5</release>
	Legend = 59703,

	/// <summary>Legend Left</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, key, symbols, shapes, items, map, point symbols, alignment</remarks>
	/// <release>1.5</release>
	LegendLeft = 59704,

	/// <summary>Legend Plus</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, key, symbols, shapes, items, map, point symbols, add</remarks>
	/// <release>1.5</release>
	LegendPlus = 59705,

	/// <summary>Legend Right</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, key, symbols, shapes, items, map, point symbols, alignment</remarks>
	/// <release>1.5</release>
	LegendRight = 59706,

	/// <summary>License</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, pass, driver's license, pilot's license, identification, government issued ID, photo ID, person, certification, student ID, card</remarks>
	/// <release>3.15.2</release>
	License = 59707,

	/// <summary>Light Rain</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, misty, clouds</remarks>
	/// <release>3.17.6</release>
	LightRain = 59708,

	/// <summary>Light Snow</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, freezing</remarks>
	/// <release>3.17.6</release>
	LightSnow = 59709,

	/// <summary>Lightbulb</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, tips, help, ideas</remarks>
	/// <release>1.5</release>
	Lightbulb = 59710,

	/// <summary>Line</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.25.2, geometry editing, gis, feature, draw, points</remarks>
	/// <release>3.25.2</release>
	Line = 59711,

	/// <summary>Line Check</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.2, check mark, confirm, drawing, draw line</remarks>
	/// <release>2.3.2</release>
	LineCheck = 59712,

	/// <summary>Line Dashed</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.2.0, chart, style, drawing</remarks>
	/// <release>3.2.0</release>
	LineDashed = 59713,

	/// <summary>Line Dotted</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.2.0, chart, style, drawing</remarks>
	/// <release>3.2.0</release>
	LineDotted = 59714,

	/// <summary>Line Of Sight</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.12.1, line of sight, viewshed, visible, eye, building</remarks>
	/// <release>3.12.1</release>
	LineOfSight = 59715,

	/// <summary>Line Solid</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.2.0, chart, style, drawing</remarks>
	/// <release>3.2.0</release>
	LineSolid = 59716,

	/// <summary>Line Straight</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.25.2, geometry editing, gis, diagonal, points, feature</remarks>
	/// <release>3.25.2</release>
	LineStraight = 59717,

	/// <summary>Link</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, chain</remarks>
	/// <release>1.5</release>
	Link = 59718,

	/// <summary>Link Chart</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.20.6, knowledge graph, link chart, relationships, spatial data, non spatial data, query, spatial analysis, investigation, data model, scale, link, select</remarks>
	/// <release>3.20.6</release>
	LinkChart = 59719,

	/// <summary>Link Chart Expand</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial data, spatial analysis, data model, add to</remarks>
	/// <release>3.23.6</release>
	LinkChartExpand = 59720,

	/// <summary>Link Chart From Template</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.25.8, knowledge graph, charts, information, link chart, data model, template</remarks>
	/// <release>3.25.8</release>
	LinkChartFromTemplate = 59721,

	/// <summary>List</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, items, lines</remarks>
	/// <release>1.5</release>
	List = 59722,

	/// <summary>List Bullet</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, itemized, items, multiple, collection, lines, points</remarks>
	/// <release>1.5</release>
	ListBullet = 59723,

	/// <summary>List Button</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, choice, choose, multiple selection, select, text, click, options</remarks>
	/// <release>1.5</release>
	ListButton = 59724,

	/// <summary>List Check</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, completed, items, to-do list, to do list, tasks</remarks>
	/// <release>1.5</release>
	ListCheck = 59725,

	/// <summary>List Check All</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.19.2, lists, alignments, checks, marks, paragraphs, tasks, completed, items, to-do lists, text, itemized</remarks>
	/// <release>3.19.2</release>
	ListCheckAll = 59726,

	/// <summary>List Merge</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, items, collapse list</remarks>
	/// <release>1.5</release>
	ListMerge = 59727,

	/// <summary>List Number</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, numbered, itemized, sequence, in order, steps, to-do, tasks, follow, count, tally</remarks>
	/// <release>1.5</release>
	ListNumber = 59728,

	/// <summary>List Number Rtl</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.0.0, ordering, rtl, right to left, list numbers, numbered list, ordered list</remarks>
	/// <release>3.0.0</release>
	ListNumberRtl = 59729,

	/// <summary>List Radio</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, selected, items, itemized, single selection, choose, choice, options</remarks>
	/// <release>1.5</release>
	ListRadio = 59730,

	/// <summary>List Rectangle</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.0.0, list rectangle, domain, list of values, list of unique values, dropdown menu, dropdown selection</remarks>
	/// <release>3.0.0-beta.6</release>
	ListRectangle = 59731,

	/// <summary>List Show All</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, drop down, more, extend, total, sub, items</remarks>
	/// <release>1.5</release>
	ListShowAll = 59732,

	/// <summary>Livestream Video Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.27.5, layers, video, livestream, file, media, images, picture</remarks>
	/// <release>3.27.5</release>
	LivestreamVideoLayer = 59733,

	/// <summary>Location Sharing (Filled)</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.22.3, gis, tracking, location, field, route, filled, directions</remarks>
	/// <release>3.22.3</release>
	LocationSharingFilled = 59734,

	/// <summary>Location Sharing</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.22.3, gis, tracking, on, location, field, enabled, route, directions</remarks>
	/// <release>3.22.3</release>
	LocationSharing = 59735,

	/// <summary>Location Sharing Off</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.22.3, gis, tracking, off, location, field, disabled, route, directions</remarks>
	/// <release>3.22.3</release>
	LocationSharingOff = 59736,

	/// <summary>Locator</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.7.0, house, geocoding, geolocator, georeferencing, home</remarks>
	/// <release>2.7.0</release>
	Locator = 59737,

	/// <summary>Lock (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, secure, guarded, permission, security, restricted, privacy, filled</remarks>
	/// <release>1.5</release>
	LockFilled = 59738,

	/// <summary>Lock</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, secure, guarded, permission, security, restricted, privacy</remarks>
	/// <release>1.5</release>
	Lock = 59739,

	/// <summary>Ltr Elements Align</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.19.3, windows, move, right, left, objects, horizontal, alignment, shapes, boxes, UI</remarks>
	/// <release>3.19.3</release>
	LtrElementsAlign = 59740,

	/// <summary>Ltr Paragraph Align</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.25.2, text, symbols, move, left, right, arrow, direction, format</remarks>
	/// <release>3.25.2</release>
	LtrParagraphAlign = 59741,

	/// <summary>Magnifying Glass</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, zoom, magnify, investigate, analyze, reveal, observe</remarks>
	/// <release>1.5</release>
	MagnifyingGlass = 59742,

	/// <summary>Magnifying Glass Minus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, zoom out, magnify</remarks>
	/// <release>1.5</release>
	MagnifyingGlassMinus = 59743,

	/// <summary>Magnifying Glass Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, zoom in, magnify</remarks>
	/// <release>1.5</release>
	MagnifyingGlassPlus = 59744,

	/// <summary>Map</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis</remarks>
	/// <release>1.5</release>
	Map = 59745,

	/// <summary>Map Contents</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 1.5.0, layers, list, drilldown</remarks>
	/// <release>1.5</release>
	MapContents = 59746,

	/// <summary>Map From Template</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.25.8, knowledge graph, maps, information, link chart, data model, template</remarks>
	/// <release>3.25.8</release>
	MapFromTemplate = 59747,

	/// <summary>Map Level Settings</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, web editor, maps, edit, tools, options</remarks>
	/// <release>3.25.2</release>
	MapLevelSettings = 59748,

	/// <summary>Map Pin</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.1, gis, location, map pin, map marker, destination, dropped pin, drop pin</remarks>
	/// <release>3.16.1</release>
	MapPin = 59749,

	/// <summary>Map Space</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.4, map space, ruler, measure, workspace, work mode, workmode, grid, segment</remarks>
	/// <release>2.5.4</release>
	MapSpace = 59750,

	/// <summary>Marketplace</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 1.5.0, store, brand</remarks>
	/// <release>1.5</release>
	Marketplace = 59751,

	/// <summary>Mask Inside</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.22.8, generic, mask, cover, inside, polygon, selection, hide</remarks>
	/// <release>3.22.8</release>
	MaskInside = 59752,

	/// <summary>Mask Outside</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.22.8, generic, mask, cover, outside, polygon, selection, hide</remarks>
	/// <release>3.22.8</release>
	MaskOutside = 59753,

	/// <summary>Maximize</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, header, dock-top, panel</remarks>
	/// <release>1.5</release>
	Maximize = 59754,

	/// <summary>Maximum</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.1.0, max, mathematics, numbers, formula, calculation, function</remarks>
	/// <release>3.1.0</release>
	Maximum = 59755,

	/// <summary>Maximum Graph</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.25.2, charts and graphs, max, mathematics, numbers, formula, calculation, function, maximum graph, parabolic curve</remarks>
	/// <release>3.25.2</release>
	MaximumGraph = 59756,

	/// <summary>Maximum Territory Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.18.9, gis, measure, border, area, between</remarks>
	/// <release>3.18.9</release>
	MaximumTerritoryDistance = 59757,

	/// <summary>Measure</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, ruler, distance, metric, measurement</remarks>
	/// <release>1.5</release>
	Measure = 59758,

	/// <summary>Measure Area</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, measure perimeter, measure space, measure polygon, measure plot, ruler</remarks>
	/// <release>1.5</release>
	MeasureArea = 59759,

	/// <summary>Measure Building Height Shadow</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, measure, buildings, height, distance</remarks>
	/// <release>1.6</release>
	MeasureBuildingHeightShadow = 59760,

	/// <summary>Measure Building Height Top Base</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, measure, buildings, height, distance</remarks>
	/// <release>1.6</release>
	MeasureBuildingHeightTopBase = 59761,

	/// <summary>Measure Building Height Top Shadow</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, measure, buildings, height, distance</remarks>
	/// <release>1.6</release>
	MeasureBuildingHeightTopShadow = 59762,

	/// <summary>Measure Line</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, measure distance, ruler</remarks>
	/// <release>1.5</release>
	MeasureLine = 59763,

	/// <summary>Media Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.21.0, layers, images, imagery, file, assets, photos, feature, picture, gis</remarks>
	/// <release>3.21.0</release>
	MediaLayer = 59764,

	/// <summary>Mega Phone</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, promote, announcement, new, updates, new features</remarks>
	/// <release>1.5</release>
	MegaPhone = 59765,

	/// <summary>Members Brackets</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.27.7, objects, frame, select, member</remarks>
	/// <release>3.27.7</release>
	MembersBrackets = 59766,

	/// <summary>Merge 2</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.25.2, arrows, generic, merging, combine, connect, involve</remarks>
	/// <release>3.25.2</release>
	Merge2 = 59767,

	/// <summary>Merge</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, combine, unite, consolidate</remarks>
	/// <release>3.0.0</release>
	Merge = 59768,

	/// <summary>Merge Details</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, merging, information, content, combine, connect, infuse</remarks>
	/// <release>3.25.2</release>
	MergeDetails = 59769,

	/// <summary>Merge On Highway</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, enter, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	MergeOnHighway = 59770,

	/// <summary>Merge On Highway Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, enter, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	MergeOnHighwayRight = 59771,

	/// <summary>Merge Units</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, merging, units, combine, connect, infuse, arrows, dotted lines</remarks>
	/// <release>3.25.2</release>
	MergeUnits = 59772,

	/// <summary>Microphone</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 2.2.0, recording, voice, sound, audio, input, podcast, radio, voiceover, music</remarks>
	/// <release>2.2.0</release>
	Microphone = 59773,

	/// <summary>Microphone Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.13.0, objects, recording, voice, sound, audio, input, podcast, radio, voiceover, music, add audio, audio clip, plus, microphone plus</remarks>
	/// <release>3.13.0</release>
	MicrophonePlus = 59774,

	/// <summary>Min Distance Between Centers</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.18.9, gis, measure, area, between, border</remarks>
	/// <release>3.18.9</release>
	MinDistanceBetweenCenters = 59775,

	/// <summary>Minimize</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, undock</remarks>
	/// <release>1.5</release>
	Minimize = 59776,

	/// <summary>Minimum</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.1.0, min, mathematics, numbers, formula, calculation, function</remarks>
	/// <release>3.1.0</release>
	Minimum = 59777,

	/// <summary>Minimum Graph</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.25.2, charts and graphs, min, mathematics, numbers, formula, calculation, function, minimum graph, parabolic curve</remarks>
	/// <release>3.25.2</release>
	MinimumGraph = 59778,

	/// <summary>Minus</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, zoomout, dash</remarks>
	/// <release>1.5</release>
	Minus = 59779,

	/// <summary>Minus Circle (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.24.2, symbols, stop, delete, remove, restricted, subtract, filled</remarks>
	/// <release>3.24.2</release>
	MinusCircleFilled = 59780,

	/// <summary>Minus Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.24.2, symbols, stop, delete, remove, restricted, subtract</remarks>
	/// <release>3.24.2</release>
	MinusCircle = 59781,

	/// <summary>Minus Square (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.6, symbols, hyphen, line, filled, subtract, filled</remarks>
	/// <release>3.23.6</release>
	MinusSquareFilled = 59782,

	/// <summary>Minus Square</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.6, symbols, hyphen, line, filled, subtract</remarks>
	/// <release>3.23.6</release>
	MinusSquare = 59783,

	/// <summary>Miscellaneous Collection</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.14.0, symbols, collection, miscellaneous collection, components, hosts, severs, manage, manual, reports</remarks>
	/// <release>3.14.0</release>
	MiscellaneousCollection = 59784,

	/// <summary>Mission Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.8, gis, connected, connection, product, host</remarks>
	/// <release>3.21.8</release>
	MissionServer = 59785,

	/// <summary>Mobile</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, phone, device</remarks>
	/// <release>1.5</release>
	Mobile = 59786,

	/// <summary>Mobile Off</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.10.0, mobile off, no cell service, no service, no reception, non-mobile app, desktop app</remarks>
	/// <release>3.10.0</release>
	MobileOff = 59787,

	/// <summary>Mobile Vibrate</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.8, objects, cell phone, device, vibration, settings, sounds, haptics, mode, alert, notification</remarks>
	/// <release>3.16.8</release>
	MobileVibrate = 59788,

	/// <summary>Model</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, online model builder, models, shapes, lines, circles, squares</remarks>
	/// <release>3.25.2</release>
	Model = 59789,

	/// <summary>Model Edit</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.27.2, knowledge graph, edit, model, change, modify</remarks>
	/// <release>3.27.2</release>
	ModelEdit = 59790,

	/// <summary>Model History</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, history, time, edit</remarks>
	/// <release>3.32.0</release>
	ModelHistory = 59791,

	/// <summary>Modify Associations</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.0, gis, gear, changes, adjusting, associated, modified</remarks>
	/// <release>3.28.0</release>
	ModifyAssociations = 59792,

	/// <summary>Monitor</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, desktop, computer, windows, screen</remarks>
	/// <release>1.6</release>
	Monitor = 59793,

	/// <summary>Moon</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.1, night mode, dark mode, dark theme</remarks>
	/// <release>2.5.1</release>
	Moon = 59794,

	/// <summary>Move</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, pan, drag, arrows, navigate, up, down, left, right</remarks>
	/// <release>1.5</release>
	Move = 59795,

	/// <summary>Move From Basemap</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.9, gis, basemaps, out, change, data</remarks>
	/// <release>3.25.9</release>
	MoveFromBasemap = 59796,

	/// <summary>Move To Basemap</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.9, gis, basemaps, in, change, data</remarks>
	/// <release>3.25.9</release>
	MoveToBasemap = 59797,

	/// <summary>Move Up</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, shift, relocate, send</remarks>
	/// <release>1.5</release>
	MoveUp = 59798,

	/// <summary>Move Up All</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, shift, relocate, send, double</remarks>
	/// <release>1.5</release>
	MoveUpAll = 59799,

	/// <summary>Mu</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.1.0, statistical mean, population mean, statistics, average, greek letter, mathematics, arithmetic, function, arithmetic, formula</remarks>
	/// <release>3.1.0</release>
	Mu = 59800,

	/// <summary>Multiple Variables</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.18.1, symbols, shapes, variety, geometry, filled, outline, diversity, difference, variation, mixed, changes, combo, collection</remarks>
	/// <release>3.18.1</release>
	MultipleVariables = 59801,

	/// <summary>Music Note</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.7.0, music note, beat, tone, song, sounds, melody, harmony</remarks>
	/// <release>3.7.0</release>
	MusicNote = 59802,

	/// <summary>New Link Chart</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial data, spatial analysis, data model</remarks>
	/// <release>3.23.6</release>
	NewLinkChart = 59803,

	/// <summary>New Model</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, online model builder, models, shapes, lines, circles, squares, adding, create</remarks>
	/// <release>3.25.2</release>
	NewModel = 59804,

	/// <summary>New Raster Function Template</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.9, GIS, fx, edit, raster, modify, new, list, categories</remarks>
	/// <release>3.21.9</release>
	NewRasterFunctionTemplate = 59805,

	/// <summary>New Training</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, new, create</remarks>
	/// <release>3.17.1</release>
	NewTraining = 59806,

	/// <summary>No Attachment</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, no-file, paper clip, empty, missing, none, off</remarks>
	/// <release>3.16.6</release>
	NoAttachment = 59807,

	/// <summary>No Image</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.16.6, media, no picture, no photograph, no picture, no-file, empty, missing, none, off</remarks>
	/// <release>3.16.6</release>
	NoImage = 59808,

	/// <summary>No Map</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: map, no map, unavailable, disable</remarks>
	/// <release>2.4.1</release>
	NoMap = 59809,

	/// <summary>Nodes Link</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, link nodes, link points</remarks>
	/// <release>1.5</release>
	NodesLink = 59810,

	/// <summary>Nodes Merge</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, combine nodes, merge nodes, combine points, combine nodes</remarks>
	/// <release>1.5</release>
	NodesMerge = 59811,

	/// <summary>Nodes Unlink</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, unlink nodes, unlink points</remarks>
	/// <release>1.5</release>
	NodesUnlink = 59812,

	/// <summary>Nodes Unmerge</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.25.2, arrows, separate points, separate nodes, unmerge nodes, unmerge points</remarks>
	/// <release>3.25.2</release>
	NodesUnmerge = 59813,

	/// <summary>Notebook</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 2.7.0, python notebook, jupyter notebook, api for python</remarks>
	/// <release>2.7.0</release>
	Notebook = 59814,

	/// <summary>Notebook Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, books, programs, softwares, brand, connections, servers</remarks>
	/// <release>3.20.7</release>
	NotebookServer = 59815,

	/// <summary>Notebook Snapshot</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.12.0, notebook snapshot, python notebook, json notebook</remarks>
	/// <release>3.12.0</release>
	NotebookSnapshot = 59816,

	/// <summary>Notepad</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.26.0, objects, written, notes, lists, write, text, files, notebook, school</remarks>
	/// <release>3.26.0</release>
	Notepad = 59817,

	/// <summary>Notepad Add</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.26.0, objects, written, notes, lists, write, text, files, modify, notebook, create, new</remarks>
	/// <release>3.26.0</release>
	NotepadAdd = 59818,

	/// <summary>Notepad Edit</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.26.0, objects, pencil, written, notes, lists, write, text, files, modify, notebook</remarks>
	/// <release>3.26.0</release>
	NotepadEdit = 59819,

	/// <summary>Null</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, zero, nothing, empty, n/a, none</remarks>
	/// <release>1.5</release>
	Null = 59820,

	/// <summary>Number</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 2.5.3, 123, numbers, variable, datatype, integer, value</remarks>
	/// <release>2.5.3</release>
	Number = 59821,

	/// <summary>Number Circle 1 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, number circle 1, first item, list item, first step, ranking, one</remarks>
	/// <release>3.22.3</release>
	NumberCircle1Filled = 59822,

	/// <summary>Number Circle 1</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.3.0, number circle 1, first item, list item, first step, ranking, one</remarks>
	/// <release>3.3.0</release>
	NumberCircle1 = 59823,

	/// <summary>Number Circle 2 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, list item, number circle 2, second item, second step, ranking, two</remarks>
	/// <release>3.22.3</release>
	NumberCircle2Filled = 59824,

	/// <summary>Number Circle 2</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.3.0, list item, number circle 2, second item, second step, ranking, two</remarks>
	/// <release>3.3.0</release>
	NumberCircle2 = 59825,

	/// <summary>Number Circle 3 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, list item, third step, number circle 3, three, third item, ranking</remarks>
	/// <release>3.22.3</release>
	NumberCircle3Filled = 59826,

	/// <summary>Number Circle 3</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.3.0, list item, third step, number circle 3, three, third item, ranking</remarks>
	/// <release>3.3.0</release>
	NumberCircle3 = 59827,

	/// <summary>Number Circle 4 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, circle, list item, number circle 4, fourth item, fifth step, ranking, 4, four</remarks>
	/// <release>3.22.3</release>
	NumberCircle4Filled = 59828,

	/// <summary>Number Circle 4</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.4, numbers, circle, 4, four</remarks>
	/// <release>3.19.4</release>
	NumberCircle4 = 59829,

	/// <summary>Number Circle 5 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, circle, list item, number circle 5, fifth item, fifth step, ranking, 5, five</remarks>
	/// <release>3.22.3</release>
	NumberCircle5Filled = 59830,

	/// <summary>Number Circle 5</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.4, numbers, circle, 5, five</remarks>
	/// <release>3.19.4</release>
	NumberCircle5 = 59831,

	/// <summary>Number Circle 6 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, circle, list item, number circle 6, sixth item, sixth step, ranking, 6, six</remarks>
	/// <release>3.22.3</release>
	NumberCircle6Filled = 59832,

	/// <summary>Number Circle 6</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.4, numbers, circle, 6, six</remarks>
	/// <release>3.19.4</release>
	NumberCircle6 = 59833,

	/// <summary>Number Circle 7 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, circle, list item, number circle 7, seventh item, seventh step, ranking, 7, seven</remarks>
	/// <release>3.22.3</release>
	NumberCircle7Filled = 59834,

	/// <summary>Number Circle 7</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.4, numbers, circle, 7, seven</remarks>
	/// <release>3.19.4</release>
	NumberCircle7 = 59835,

	/// <summary>Number Circle 8 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, circle, list item, number circle 8, eighth item, eighth step, ranking, 8, eight</remarks>
	/// <release>3.22.3</release>
	NumberCircle8Filled = 59836,

	/// <summary>Number Circle 8</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.4, numbers, circle, 8, eight</remarks>
	/// <release>3.19.4</release>
	NumberCircle8 = 59837,

	/// <summary>Number Circle 9 (Filled)</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.22.3, numbers, filled, circle, list item, number circle 9, ninth item, ninth step, ranking, 9, nine</remarks>
	/// <release>3.22.3</release>
	NumberCircle9Filled = 59838,

	/// <summary>Number Circle 9</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 3.19.4, numbers, circle, 9, nine</remarks>
	/// <release>3.19.4</release>
	NumberCircle9 = 59839,

	/// <summary>Number Of Territories</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.18.9, gis, map, district, area, divided, region, state, land</remarks>
	/// <release>3.18.9</release>
	NumberOfTerritories = 59840,

	/// <summary>Object Detection</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.5.4, cursor, crosshair, point, object detection, tracking, track object, identify, identifying, capture, isolate</remarks>
	/// <release>2.5.4</release>
	ObjectDetection = 59841,

	/// <summary>Objectstore Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, data, object, storage, cubes, scene layers, 3d tiles, blobs</remarks>
	/// <release>3.28.3</release>
	ObjectstoreDataStore = 59842,

	/// <summary>Octagon</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.25.1, symbols, shapes, single shape, glyphs, generic, geometry</remarks>
	/// <release>3.25.1</release>
	Octagon = 59843,

	/// <summary>Offline</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 2.3.0, disconnected, internet, cloud, broken, connection, syncing</remarks>
	/// <release>2.3.0</release>
	Offline = 59844,

	/// <summary>On The Ground Elevation</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.3, gis, elevate, measure, height, depth, ground, measurements</remarks>
	/// <release>3.25.3</release>
	OnTheGroundElevation = 59845,

	/// <summary>Online</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 2.3.0, connected, internet, cloud, connection, syncing</remarks>
	/// <release>2.3.0</release>
	Online = 59846,

	/// <summary>Open Book</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.4, learning, reading, story, bookmark, literature, objects</remarks>
	/// <release>3.16.4</release>
	OpenBook = 59847,

	/// <summary>Organization</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, building, company, business</remarks>
	/// <release>1.5</release>
	Organization = 59848,

	/// <summary>Oriented Imagery Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.2, layers, gis, feature, sight, locate, data, coordinates, generic</remarks>
	/// <release>3.22.2</release>
	OrientedImageryLayer = 59849,

	/// <summary>Oriented Imagery Widget</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.0, gis, sight, vision, coordinates, locate</remarks>
	/// <release>3.17.0</release>
	OrientedImageryWidget = 59850,

	/// <summary>Outbox</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.6.0, mail, email, outgoing, arrow</remarks>
	/// <release>3.6.0</release>
	Outbox = 59851,

	/// <summary>Overlap Features</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.19.0, gis, shapes, map, area, merge, combine, polygons, unite, overlay, crop</remarks>
	/// <release>3.19.0</release>
	OverlapFeatures = 59852,

	/// <summary>Overwrite Features</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.4, layers, maps, gis, mapping, location, data, feature layers, replace, update, refresh</remarks>
	/// <release>3.22.4</release>
	OverwriteFeatures = 59853,

	/// <summary>Overwrite Project</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.28.9, objects, raster, briefcase, clear, remove, write, project</remarks>
	/// <release>3.28.9</release>
	OverwriteProject = 59854,

	/// <summary>Package</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.17.0, Objects, stack, sdk, api, programming, software, kit, development, build, blocks, deliver, group</remarks>
	/// <release>3.17.0</release>
	Package = 59855,

	/// <summary>Paint Bucket</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, drawing, tool, fill, painting, art, color, illustrate, design, 3.16.6, objects, drawing, tool, instrument, painting, art, freehand, illustrate, design</remarks>
	/// <release>3.16.6</release>
	PaintBucket = 59856,

	/// <summary>Palette</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, appearances, design, themes, color</remarks>
	/// <release>1.5</release>
	Palette = 59857,

	/// <summary>Palette Check</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.1, objects, appearances, design, themes, color, templates, approved, branded, reviewed, checked, check mark, quality, authorized, art, styles, endorsed</remarks>
	/// <release>3.18.1</release>
	PaletteCheck = 59858,

	/// <summary>Pan</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.7.0, drag, grab, move, hand, span, cursor, grabbing, dragging</remarks>
	/// <release>1.7.0</release>
	Pan = 59859,

	/// <summary>Pan Drag</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.7.0, drag, grab, move, hand, span, cursor, grabbing, dragging</remarks>
	/// <release>1.7.0</release>
	PanDrag = 59860,

	/// <summary>Parcel Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.2, layers, gis, features, assets, data, points, lines</remarks>
	/// <release>3.22.2</release>
	ParcelLayer = 59861,

	/// <summary>Partly Cloudy</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, sunny, clouds, sunshine</remarks>
	/// <release>3.17.6</release>
	PartlyCloudy = 59862,

	/// <summary>Partner</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.24.9, people, hand shake, agreement, hands, partnership, corporate, assistance, agreement, collaboration, collaborate, colleagues, peers</remarks>
	/// <release>3.24.9</release>
	Partner = 59863,

	/// <summary>Paste</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects</remarks>
	/// <release>1.5</release>
	Paste = 59864,

	/// <summary>Paste With Attribute</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.0, generic, pasting, copy, pasted, added, attributes</remarks>
	/// <release>3.28.0</release>
	PasteWithAttribute = 59865,

	/// <summary>Paste Without Attribute</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.0, generic, pasting, copy, pasted, added, removed, attributes</remarks>
	/// <release>3.28.0</release>
	PasteWithoutAttribute = 59866,

	/// <summary>Pause (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, filled</remarks>
	/// <release>1.5</release>
	PauseFilled = 59867,

	/// <summary>Pause</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media</remarks>
	/// <release>1.5</release>
	Pause = 59868,

	/// <summary>Pen</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, signature, authorize</remarks>
	/// <release>1.5</release>
	Pen = 59869,

	/// <summary>Pen Mark</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: objects, 3.17.3, signature, authorize, writing, endorse, license</remarks>
	/// <release>3.17.3</release>
	PenMark = 59870,

	/// <summary>Pen Mark Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: objects, 3.17.3, signature, authorize, writing, endorse, license</remarks>
	/// <release>3.17.3</release>
	PenMarkPlus = 59871,

	/// <summary>Pen Tip</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, drawing, tool, instrument, art, freehand, illustrate, design, write, signature</remarks>
	/// <release>3.16.6</release>
	PenTip = 59872,

	/// <summary>Pencil</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, edit, modify, draw</remarks>
	/// <release>1.5</release>
	Pencil = 59873,

	/// <summary>Pencil Mark</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.6.0, drawing, squiggle, sketching, annotate, signature, markup, marking, pencil mark</remarks>
	/// <release>3.6.0</release>
	PencilMark = 59874,

	/// <summary>Pencil Mark Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.13.0, objects, drawing, squiggle, sketching, annotate, signature, markup, marking, pencil mark plus, add, plus</remarks>
	/// <release>3.13.0</release>
	PencilMarkPlus = 59875,

	/// <summary>Pencil Square</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, edit, square</remarks>
	/// <release>1.5</release>
	PencilSquare = 59876,

	/// <summary>Pencil Tip</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.6, objects, drawing, tool, instrument, write, art, freehand, illustrate, design</remarks>
	/// <release>3.16.6</release>
	PencilTip = 59877,

	/// <summary>Pentagon</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.18.1, symbols, shapes, single shape, one variable, geometry</remarks>
	/// <release>3.18.1</release>
	Pentagon = 59878,

	/// <summary>Percent</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.1.0, percentage, fraction, ratio, mathematics</remarks>
	/// <release>3.1.0</release>
	Percent = 59879,

	/// <summary>Person 2</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.0.0, da vinci man, human being, body, health, person 2, standing, exercise</remarks>
	/// <release>3.0.0</release>
	Person2 = 59880,

	/// <summary>Person</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, standing, stand, men, women, man, woman, people</remarks>
	/// <release>1.5</release>
	Person = 59881,

	/// <summary>Personal Homepage</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.8, generic, Generic, 3.20.8, home, user, house, person, single</remarks>
	/// <release>3.20.8</release>
	PersonalHomepage = 59882,

	/// <summary>Phone</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, call, contact</remarks>
	/// <release>1.5</release>
	Phone = 59883,

	/// <summary>Pie Chart</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, pie chart, percentage, statistics, stats, demographics, portion, ratio, allocation, portfolio, infographic</remarks>
	/// <release>1.5</release>
	PieChart = 59884,

	/// <summary>Pin</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, location, feature</remarks>
	/// <release>1.5</release>
	Pin = 59885,

	/// <summary>Pin Plus</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, add, location</remarks>
	/// <release>1.5</release>
	PinPlus = 59886,

	/// <summary>Pin Tear (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.1, generic, location, map pin, map marker, destination, dropped pin, drop pin, filled</remarks>
	/// <release>3.16.1</release>
	PinTearFilled = 59887,

	/// <summary>Pin Tear</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.1, generic, location, map pin, map marker, destination, dropped pin, drop pin</remarks>
	/// <release>3.16.1</release>
	PinTear = 59888,

	/// <summary>Pins</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.12.1, pins, explore, locations, storymaps, places, map pins</remarks>
	/// <release>3.12.1</release>
	Pins = 59889,

	/// <summary>Plane</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, airplane, aircraft, airport, commercial jet, transportation, flying, flight, commute, commuting, cargo plane</remarks>
	/// <release>1.5</release>
	Plane = 59890,

	/// <summary>Plans</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, blueprint, layout, measurements, perimeter, width, height, boundary, interior, scale</remarks>
	/// <release>3.0.0</release>
	Plans = 59891,

	/// <summary>Play (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, run, test, filled</remarks>
	/// <release>1.5</release>
	PlayFilled = 59892,

	/// <summary>Play</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, run, test</remarks>
	/// <release>1.5</release>
	Play = 59893,

	/// <summary>Plus</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, add, zoom</remarks>
	/// <release>1.5</release>
	Plus = 59894,

	/// <summary>Plus Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, add, expand, increment, increase</remarks>
	/// <release>1.5</release>
	PlusCircle = 59895,

	/// <summary>Plus Square</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, add, expand</remarks>
	/// <release>1.5</release>
	PlusSquare = 59896,

	/// <summary>Point</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, feature, location</remarks>
	/// <release>1.5</release>
	Point = 59897,

	/// <summary>Point Line</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.23.8, geometry editing, edge, points, lines, focus, extend</remarks>
	/// <release>3.23.8</release>
	PointLine = 59898,

	/// <summary>Polygon</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, feature, area</remarks>
	/// <release>1.5</release>
	Polygon = 59899,

	/// <summary>Polygon Line Check</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, vertices, polygon line check, check mark, points</remarks>
	/// <release>3.0.0</release>
	PolygonLineCheck = 59900,

	/// <summary>Polygon Select</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, dotted lines, arrows, selecting, mouse, selection</remarks>
	/// <release>3.25.2</release>
	PolygonSelect = 59901,

	/// <summary>Polygon Vertices</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.2, polygon, vertex</remarks>
	/// <release>2.3.2</release>
	PolygonVertices = 59902,

	/// <summary>Pop Up 1</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.1, generic, first location, map pin, map marker, destination, dropped pin, drop pin, one, box pin</remarks>
	/// <release>3.16.1</release>
	PopUp1 = 59903,

	/// <summary>Pop Up Blank (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.1, generic, location, map pin, map marker, destination, dropped pin, drop pin, box pin</remarks>
	/// <release>3.16.1</release>
	PopUpBlankFilled = 59904,

	/// <summary>Pop Up Blank</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.1, generic, location, map pin, map marker, destination, dropped pin, drop pin, box pin</remarks>
	/// <release>3.16.1</release>
	PopUpBlank = 59905,

	/// <summary>Popup</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, feature details, metadata, description</remarks>
	/// <release>1.5</release>
	Popup = 59906,

	/// <summary>Portal</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 1.5.0, brand, cloud</remarks>
	/// <release>1.5</release>
	Portal = 59907,

	/// <summary>Premium Content User Credit</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people, web, application, coins, money, shield, person, account, user, status</remarks>
	/// <release>1.5</release>
	PremiumContentUserCredit = 59908,

	/// <summary>Presentation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, preview, show, display, slideshow</remarks>
	/// <release>1.5</release>
	Presentation = 59909,

	/// <summary>Presentation X</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.24.8, generic, presentation, slide, exit, close, quit, x</remarks>
	/// <release>3.24.8</release>
	PresentationX = 59910,

	/// <summary>Preserve</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, intersect, intersection, overlap</remarks>
	/// <release>3.0.0</release>
	Preserve = 59911,

	/// <summary>Print</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects</remarks>
	/// <release>1.5</release>
	Print = 59912,

	/// <summary>Print Preview</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 2.5.5, printer, magnifying glass, print display, print preview</remarks>
	/// <release>2.5.5</release>
	PrintPreview = 59913,

	/// <summary>Processing Templates</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.0, gis, layers, graphics, effects, functions, list, items, fx</remarks>
	/// <release>3.17.0</release>
	ProcessingTemplates = 59914,

	/// <summary>Profile Variables</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.1, generic, variables, math, equation, x, mathematics, parentheses, calculation</remarks>
	/// <release>3.19.1</release>
	ProfileVariables = 59915,

	/// <summary>Project Mission</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 3.25.2, brand, files, mission, project, missions</remarks>
	/// <release>3.25.2</release>
	ProjectMission = 59916,

	/// <summary>Project Template</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.24.4, gis, box, package, list, template, project</remarks>
	/// <release>3.24.4</release>
	ProjectTemplate = 59917,

	/// <summary>Projects</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.0.0, briefcase, portfolio case, collection</remarks>
	/// <release>3.0.0</release>
	Projects = 59918,

	/// <summary>Properties</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, raster function template, template, data, function, information</remarks>
	/// <release>3.25.2</release>
	Properties = 59919,

	/// <summary>Pushpin</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, tack</remarks>
	/// <release>1.5</release>
	Pushpin = 59920,

	/// <summary>Puzzle Piece</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.1, objects, problem solve, solving, idea, brainstorm, goal, objectives, accomplishment, reason, logic, plug-in, add-on, extension, solution</remarks>
	/// <release>3.18.1</release>
	PuzzlePiece = 59921,

	/// <summary>Qr Code</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, app-studio, scan code, bar code, URL, link, website</remarks>
	/// <release>1.5</release>
	QrCode = 59922,

	/// <summary>Qt Code</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, brackets, app-studio, developer</remarks>
	/// <release>1.5</release>
	QtCode = 59923,

	/// <summary>Query</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.8, gis, searching, query, data, data types, database canister, arcgis knowledge</remarks>
	/// <release>3.25.8</release>
	Query = 59924,

	/// <summary>Question (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, faq, unknown, help, hint, filled</remarks>
	/// <release>1.5</release>
	QuestionFilled = 59925,

	/// <summary>Question</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, faq, unknown, help, hint</remarks>
	/// <release>1.5</release>
	Question = 59926,

	/// <summary>Question Mark</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.9.0, question mark, unknown, help, hint, faq</remarks>
	/// <release>3.9.0</release>
	QuestionMark = 59927,

	/// <summary>Quote</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.3.0, quotation marks, reference</remarks>
	/// <release>3.3.0</release>
	Quote = 59928,

	/// <summary>Radial Tree Link Chart Yayout</summary>
	RadialTreeLinkChartYayout = 59929,

	/// <summary>Rain</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, wind, stormy, clouds</remarks>
	/// <release>3.17.6</release>
	Rain = 59930,

	/// <summary>Rain Snow</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, rainy, freezing, stormy, clouds</remarks>
	/// <release>3.17.6</release>
	RainSnow = 59931,

	/// <summary>Rain Thunder</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, lightning, stormy, severe weather, clouds</remarks>
	/// <release>3.17.6</release>
	RainThunder = 59932,

	/// <summary>Ramp Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, exit, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	RampLeft = 59933,

	/// <summary>Ramp Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, freeway, exit, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	RampRight = 59934,

	/// <summary>Rangefinder</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.19.2, objects, devices, distance, measurements, instruments, sensors, tracker, tool, technology, electronic, lasers, transmit, connections, signals, mapping</remarks>
	/// <release>3.19.2</release>
	Rangefinder = 59935,

	/// <summary>Raster Function Template</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.9, GIS, fx, edit, raster, modify</remarks>
	/// <release>3.21.9</release>
	RasterFunctionTemplate = 59936,

	/// <summary>Raster Function Template History</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, edit, modify, raster, fx, template, text</remarks>
	/// <release>3.32.0</release>
	RasterFunctionTemplateHistory = 59937,

	/// <summary>Raster Function Template Play</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.5, gis, function, window, launch, media, editor, pane, share</remarks>
	/// <release>3.25.5</release>
	RasterFunctionTemplatePlay = 59938,

	/// <summary>Read Only Non Editable</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.21.2, objects, pencil, do not, backslash, prohibited, don't edit</remarks>
	/// <release>3.21.2</release>
	ReadOnlyNonEditable = 59939,

	/// <summary>Recent</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, history</remarks>
	/// <release>1.5</release>
	Recent = 59940,

	/// <summary>Rectangle</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, shape, box</remarks>
	/// <release>1.5</release>
	Rectangle = 59941,

	/// <summary>Rectangle Plus</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, draw, sketch, create rectangle, new rectangle, add rectangle, box</remarks>
	/// <release>1.5</release>
	RectanglePlus = 59942,

	/// <summary>Recurrence</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.19.0, directions, repeat, reoccur, arrows, around, circle, event</remarks>
	/// <release>3.19.0</release>
	Recurrence = 59943,

	/// <summary>Recycle Bin</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.23.1, objects, delete, store, move, remove, reuse, arrows</remarks>
	/// <release>3.23.1</release>
	RecycleBin = 59944,

	/// <summary>Redo</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.15.1, arrows, forward</remarks>
	/// <release>1.5</release>
	Redo = 59945,

	/// <summary>Refresh (Filled)</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.32.0, arrows, fill, circles, updates, arrows, repeat</remarks>
	/// <release>3.32.0</release>
	RefreshFilled = 59946,

	/// <summary>Register</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.1, generic, information, labeling, correct, check mark, approved</remarks>
	/// <release>3.20.1</release>
	Register = 59947,

	/// <summary>Relational Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, gis database, generic, technology, map pin, location</remarks>
	/// <release>3.28.3</release>
	RelationalDataStore = 59948,

	/// <summary>Relative Direction</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.25.3, geometry editing, arrows, movement, points, lines, directions</remarks>
	/// <release>3.25.3</release>
	RelativeDirection = 59949,

	/// <summary>Relative To Ground Elevation</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.3, gis, elevate, measure, height, depth, ground, measurements</remarks>
	/// <release>3.25.3</release>
	RelativeToGroundElevation = 59950,

	/// <summary>Relative To Scene Elevation</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.3, gis, elevate, measure, height, depth, scenic, scene, buildings, measurements</remarks>
	/// <release>3.25.3</release>
	RelativeToSceneElevation = 59951,

	/// <summary>Remove From List</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.27.2, lists, remove, list, disappear, items</remarks>
	/// <release>3.27.2</release>
	RemoveFromList = 59952,

	/// <summary>Remove Linkchart</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.25.2, knowledge graph, remove, close, linkchart, data</remarks>
	/// <release>3.25.2</release>
	RemoveLinkchart = 59953,

	/// <summary>Reorder Cards</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.8.0, Windows, reorder cards, arrange cards</remarks>
	/// <release>3.8.0</release>
	ReorderCards = 59954,

	/// <summary>Reorder Grid</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.8.0, Windows, reorder grid, arrange grid</remarks>
	/// <release>3.8.0</release>
	ReorderGrid = 59955,

	/// <summary>Reorder Stack</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.8.0, Windows, reorder stack, arrange stack</remarks>
	/// <release>3.8.0</release>
	ReorderStack = 59956,

	/// <summary>Replace Image</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.21.4, generic, imagery, picture, change, substitute, swap</remarks>
	/// <release>3.21.4</release>
	ReplaceImage = 59957,

	/// <summary>Reset</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, previous, backwards, clear, restart, reboot</remarks>
	/// <release>1.5</release>
	Reset = 59958,

	/// <summary>Reshape Add Geometry</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.27.3, geometry editing, lines, points, reshape, add, angles</remarks>
	/// <release>3.27.3</release>
	ReshapeAddGeometry = 59959,

	/// <summary>Reshape Tool</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.27.3, geometry editing, lines, points, reshape, movement</remarks>
	/// <release>3.27.3</release>
	ReshapeTool = 59960,

	/// <summary>Resize Area</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.14.4, windows, scale, drag, adjust, size adjust</remarks>
	/// <release>3.14.4</release>
	ResizeArea = 59961,

	/// <summary>Retrain</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: gis, 3.17.1, geoai, train</remarks>
	/// <release>3.17.1</release>
	Retrain = 59962,

	/// <summary>Reverse (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media, filled</remarks>
	/// <release>1.5</release>
	ReverseFilled = 59963,

	/// <summary>Reverse</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 1.5.0, media</remarks>
	/// <release>1.5</release>
	Reverse = 59964,

	/// <summary>Rfid</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.19.2, objects, device, chip, payment, radio frequency identification, sensor, track, tag, tool, technology, electronic, electromagnetic, transmit, connection, signal, antenna</remarks>
	/// <release>3.19.2</release>
	Rfid = 59965,

	/// <summary>Rhombus</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.19.8, symbols, shape, shapes, single shape, one variable, geometry, glyph</remarks>
	/// <release>3.19.8</release>
	Rhombus = 59966,

	/// <summary>Ribbon</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects</remarks>
	/// <release>1.5</release>
	Ribbon = 59967,

	/// <summary>Ribbon Rosette</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.1, objects, award, special, favorite, unique, best, prize, trophy, rank, winner, featured, branded, approved, reviewed, checked, check mark, quality, authorized, passed, endorsed</remarks>
	/// <release>3.18.1</release>
	RibbonRosette = 59968,

	/// <summary>Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn right, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	Right = 59969,

	/// <summary>Right Align</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.18.0, text, alignment, typography, paragraph, type, body text, format, justification, justify</remarks>
	/// <release>3.18.0</release>
	RightAlign = 59970,

	/// <summary>Right Angle</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.23.8, geometry editing, lines, points, angles, curves, degrees</remarks>
	/// <release>3.23.8</release>
	RightAngle = 59971,

	/// <summary>Right Edge</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.7.0, right edge, next, right side</remarks>
	/// <release>3.7.0</release>
	RightEdge = 59972,

	/// <summary>Right Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	RightLeft = 59973,

	/// <summary>Right Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	RightRight = 59974,

	/// <summary>Rings</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, gis, location, circles, locate, buffer, boundaries, radius</remarks>
	/// <release>1.5</release>
	Rings = 59975,

	/// <summary>Rings Largest</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, radius, location, circles, map, visualization, mapping, buffer, boundaries, location</remarks>
	/// <release>3.17.5</release>
	RingsLargest = 59976,

	/// <summary>Rings Smallest</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, radius, location, circles, map, visualization, mapping, buffer, boundaries, location</remarks>
	/// <release>3.17.5</release>
	RingsSmallest = 59977,

	/// <summary>Rings Threshold</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.6, gis, ring, time, threshold</remarks>
	/// <release>3.17.6</release>
	RingsThreshold = 59978,

	/// <summary>Rings X Bar</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.17.5, gis, area, radius, location, circles, map, visualization, mapping, buffer, boundaries, location, medium, average, median, mean, middle, formula, mathematics</remarks>
	/// <release>3.17.5</release>
	RingsXBar = 59979,

	/// <summary>Road Sign</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, directions</remarks>
	/// <release>1.5</release>
	RoadSign = 59980,

	/// <summary>Rosette</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.19.8, symbols, shape, shapes, single shape, one variable, geometry, glyph</remarks>
	/// <release>3.19.8</release>
	Rosette = 59981,

	/// <summary>Rotate</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, revolve, clockwise, counter-clockwise, edit, transform, adjust</remarks>
	/// <release>1.5</release>
	Rotate = 59982,

	/// <summary>Rotate Device</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, device, horizontal, vertical, tablet, phone</remarks>
	/// <release>1.6</release>
	RotateDevice = 59983,

	/// <summary>Round About</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, circular intersection, circular junction, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	RoundAbout = 59984,

	/// <summary>Round About Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, circular intersection, circular junction, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	RoundAboutRight = 59985,

	/// <summary>Rounded Rectangle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.19.8, symbols, shape, shapes, single shape, one variable, geometry, glyph</remarks>
	/// <release>3.19.8</release>
	RoundedRectangle = 59986,

	/// <summary>Route From</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, navigation, navigate, current location, step-out</remarks>
	/// <release>1.5</release>
	RouteFrom = 59987,

	/// <summary>Route To</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, navigation, navigate, destination, arrival location, step-in</remarks>
	/// <release>1.5</release>
	RouteTo = 59988,

	/// <summary>Rss (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.32.0, generic, follow, subscribe, square, web, feed, users, app, applications, updates, websites, unfollow, unsubscribe</remarks>
	/// <release>3.32.0</release>
	RssFilled = 59989,

	/// <summary>Rss</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.26.2, generic, follow, subscribe, square, web, feed, users, app, applications, updates, websites, unfollow, unsubscribe</remarks>
	/// <release>3.26.2</release>
	Rss = 59990,

	/// <summary>Rtl Elements Align</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.19.3, windows, move, right, left, objects, horizontal, alignment, shapes, boxes, UI</remarks>
	/// <release>3.19.3</release>
	RtlElementsAlign = 59991,

	/// <summary>Rtl Paragraph Align</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.25.2, text, symbols, move, left, right, arrow, direction, format</remarks>
	/// <release>3.25.2</release>
	RtlParagraphAlign = 59992,

	/// <summary>Running</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, sport, people, person, exercise, activity</remarks>
	/// <release>1.5</release>
	Running = 59993,

	/// <summary>Running Outline</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.22.1, people, sport, person, exercise, activity, movement, human</remarks>
	/// <release>3.22.1</release>
	RunningOutline = 59994,

	/// <summary>Rural Driving Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, travel, drive, car, vehicle, route, length, measure, navigate, arrows, destination, desert</remarks>
	/// <release>3.16.8</release>
	RuralDrivingDistance = 59995,

	/// <summary>Rural Driving Time</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, drive, car, vehicle, travel, timer, clock, desert, arrival, traffic</remarks>
	/// <release>3.16.8</release>
	RuralDrivingTime = 59996,

	/// <summary>Satellite 0 (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.2, objects, artificial satellite, communications, remote sensing, signal, on, off, fill</remarks>
	/// <release>3.20.2</release>
	Satellite0Filled = 59997,

	/// <summary>Satellite 0</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, artificial satellite, communication, remote sensing, no signal</remarks>
	/// <release>1.5</release>
	Satellite0 = 59998,

	/// <summary>Satellite 1 (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.2, objects, artificial satellite, communications, remote sensing, signal, on, off, fill</remarks>
	/// <release>3.20.2</release>
	Satellite1Filled = 59999,

	/// <summary>Satellite 1</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, artificial satellite, communication, remote sensing, signal</remarks>
	/// <release>1.5</release>
	Satellite1 = 60000,

	/// <summary>Satellite 2 (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.2, objects, artificial satellite, communications, remote sensing, signal, on, off, fill</remarks>
	/// <release>3.20.2</release>
	Satellite2Filled = 60001,

	/// <summary>Satellite 2</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, artificial satellite, communication, remote sensing, signal</remarks>
	/// <release>1.5</release>
	Satellite2 = 60002,

	/// <summary>Satellite 3 (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.2, objects, artificial satellite, communications, remote sensing, signal, on, off, fill</remarks>
	/// <release>3.20.2</release>
	Satellite3Filled = 60003,

	/// <summary>Satellite 3</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, artificial satellite, communication, remote sensing, full signal</remarks>
	/// <release>1.5</release>
	Satellite3 = 60004,

	/// <summary>Save</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, floppy disk</remarks>
	/// <release>1.5</release>
	Save = 60005,

	/// <summary>Save As</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, raster function template, disk, memory, action, saving, edit, modify, pencil</remarks>
	/// <release>3.25.2</release>
	SaveAs = 60006,

	/// <summary>Scan Area</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, site scan, area, drone, flight, path, track, pattern</remarks>
	/// <release>3.24.8</release>
	ScanArea = 60007,

	/// <summary>Scan Barcode</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.14.4, generic, barcode scanner, price, code</remarks>
	/// <release>3.14.4</release>
	ScanBarcode = 60008,

	/// <summary>Scan Corridor</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, site scan, area, drone, flight, path, track, pattern</remarks>
	/// <release>3.25.2</release>
	ScanCorridor = 60009,

	/// <summary>Scan Crosshatch</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, site scan, area, drone, flight, path, track, pattern</remarks>
	/// <release>3.25.2</release>
	ScanCrosshatch = 60010,

	/// <summary>Scan Perimeter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, site scan, area, drone, flight, path, track, pattern</remarks>
	/// <release>3.25.2</release>
	ScanPerimeter = 60011,

	/// <summary>Scan Vertical</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, site scan, area, drone, flight, path, track, pattern</remarks>
	/// <release>3.25.2</release>
	ScanVertical = 60012,

	/// <summary>Schema</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.26.7, generic, preview, data, features, data set, tree</remarks>
	/// <release>3.26.7</release>
	Schema = 60013,

	/// <summary>Scissors</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, cut</remarks>
	/// <release>1.5</release>
	Scissors = 60014,

	/// <summary>Screenshot Mode</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.9, generic, capture, picture, image, png, camera, lens, focus, square, corners, crop, border, extent</remarks>
	/// <release>3.17.9</release>
	ScreenshotMode = 60015,

	/// <summary>Script</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.2, objects, receipt, code, scroll, list, paper, invoice</remarks>
	/// <release>3.15.2</release>
	Script = 60016,

	/// <summary>Seamlines</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.5.3, blend, photographic, panoramic, seam</remarks>
	/// <release>2.5.3</release>
	Seamlines = 60017,

	/// <summary>Search</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, magnifying glass, locate, reveal, find, filter, search field</remarks>
	/// <release>1.5</release>
	Search = 60018,

	/// <summary>Security</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.9.0, shield, secure, protected, restricted, privacy, safety, protection, guard, defense, subscriber, user</remarks>
	/// <release>3.9.0</release>
	Security = 60019,

	/// <summary>Select</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.18.3, generic, selection, choose, cursor, point, focus, direct, freehand, point, click</remarks>
	/// <release>3.18.3</release>
	Select = 60020,

	/// <summary>Select Category</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, qualitative, checkboxes, tiles, grid, choices, categories</remarks>
	/// <release>1.5</release>
	SelectCategory = 60021,

	/// <summary>Select Range</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, quantitative</remarks>
	/// <release>1.5</release>
	SelectRange = 60022,

	/// <summary>Selected Items Filter</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.14.6, selected items filter, lists, filter selection, filter selected items</remarks>
	/// <release>3.14.6</release>
	SelectedItemsFilter = 60023,

	/// <summary>Selection Manager</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.25.8, windows, mouse, selections, selecting, click, choose, manage</remarks>
	/// <release>3.25.8</release>
	SelectionManager = 60024,

	/// <summary>Selection Set</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, web editor, pin, feature, selecting, click, choose, options, activate</remarks>
	/// <release>3.25.2</release>
	SelectionSet = 60025,

	/// <summary>Send</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.5, objects, push, paper airplane</remarks>
	/// <release>1.6.5</release>
	Send = 60026,

	/// <summary>Send Backwards</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.16.5, back, move, stack, layers, squares, order, behind</remarks>
	/// <release>3.16.5</release>
	SendBackwards = 60027,

	/// <summary>Send To Back</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.16.5, back, move, stack, layers, squares, order, behind</remarks>
	/// <release>3.16.5</release>
	SendToBack = 60028,

	/// <summary>Sensor</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.16.8, objects, device, radar, wifi, signal, communication, remote sensing, technology, smart sensor</remarks>
	/// <release>3.16.8</release>
	Sensor = 60029,

	/// <summary>Separator</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.3.0, divider</remarks>
	/// <release>3.3.0</release>
	Separator = 60030,

	/// <summary>Serial Port</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.0.0, USB port, HDMI port, Ethernet port, wires, COM port, external drive, plug, serial port</remarks>
	/// <release>3.0.0-beta.6</release>
	SerialPort = 60031,

	/// <summary>Server</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.0, generic, servers, connection</remarks>
	/// <release>3.9.0</release>
	Server = 60032,

	/// <summary>Server Lock</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.0, generic, servers, connection, secure, private, protected, locked, safe</remarks>
	/// <release>3.16.0</release>
	ServerLock = 60033,

	/// <summary>Services</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, bell, ding, ring, ask, attend, support, help, need, customer, satisfaction, attention, contact, get in touch</remarks>
	/// <release>1.5</release>
	Services = 60034,

	/// <summary>Shapes</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, shapes, triangle, square, circle</remarks>
	/// <release>1.5</release>
	Shapes = 60035,

	/// <summary>Share</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, send, collaborate, distribute, public</remarks>
	/// <release>1.5</release>
	Share = 60036,

	/// <summary>Share Ios</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, share ios, share apple, options</remarks>
	/// <release>3.0.0</release>
	ShareIos = 60037,

	/// <summary>Sharp Left</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn left, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	SharpLeft = 60038,

	/// <summary>Sharp Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, turn right, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	SharpRight = 60039,

	/// <summary>Shield Coin</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.7, generic, membership, status, access, premium, user, authoritative, safety, secure, protected, money, account</remarks>
	/// <release>3.19.7</release>
	ShieldCoin = 60040,

	/// <summary>Shopping Cart</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, purchase, buy, market, items</remarks>
	/// <release>1.5</release>
	ShoppingCart = 60041,

	/// <summary>Show All Parameters</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.25.2, forms, online model builder, display, eye, information</remarks>
	/// <release>3.25.2</release>
	ShowAllParameters = 60042,

	/// <summary>Show Column</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.9, generic, windows, table, view, eye, visible, unhide, columns, see</remarks>
	/// <release>3.16.9</release>
	ShowColumn = 60043,

	/// <summary>Show Derived Value</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.25.2, forms, online model builder, showing, eye, display, arrow, data, values</remarks>
	/// <release>3.25.2</release>
	ShowDerivedValue = 60044,

	/// <summary>Show Multiple Layers At A Time</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.4, generic, eye, layer stack, see, show, visualize</remarks>
	/// <release>3.19.4</release>
	ShowMultipleLayersAtATime = 60045,

	/// <summary>Show One Layer At A Time</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.4, generic, eye, layer stack, see, show, visualize</remarks>
	/// <release>3.19.4</release>
	ShowOneLayerAtATime = 60046,

	/// <summary>Show Required Parameters</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.25.2, forms, online model builder, eye, display, showing, hidden, selected</remarks>
	/// <release>3.25.2</release>
	ShowRequiredParameters = 60047,

	/// <summary>Sidecar</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, storymaps, scrollable content</remarks>
	/// <release>3.3.0</release>
	Sidecar = 60048,

	/// <summary>Sigma</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.1.0, arithmetic, sum, greek letter, mathematics, function, formula</remarks>
	/// <release>3.1.0</release>
	Sigma = 60049,

	/// <summary>Sign In</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, login</remarks>
	/// <release>1.5</release>
	SignIn = 60050,

	/// <summary>Sign Out</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, logout</remarks>
	/// <release>1.5</release>
	SignOut = 60051,

	/// <summary>Sky Plot</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.13.0, charts and graphs, graphs, sky plot, skyplot, graphic, satellites, elevation, azimuth, data, analysis, tracking, visualization</remarks>
	/// <release>3.13.0</release>
	SkyPlot = 60052,

	/// <summary>Slash</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.23.3, symbols, forward slash, diagonal, character, line, divider, breadcrumbs</remarks>
	/// <release>3.23.3</release>
	Slash = 60053,

	/// <summary>Slice</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, cutaway, open, 3d</remarks>
	/// <release>1.5</release>
	Slice = 60054,

	/// <summary>Sliders</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, settings, preferences, adjust</remarks>
	/// <release>1.5</release>
	Sliders = 60055,

	/// <summary>Sliders Horizontal</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, configuration</remarks>
	/// <release>1.5</release>
	SlidersHorizontal = 60056,

	/// <summary>Slideshow</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.3.0, storymaps</remarks>
	/// <release>3.3.0</release>
	Slideshow = 60057,

	/// <summary>Smart Camera</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.14.3, objects, smart camera, detect, shapes, recognition, patterns, intelligent, ai</remarks>
	/// <release>3.14.3</release>
	SmartCamera = 60058,

	/// <summary>Smart Form</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.17.2, forms, lightning, table, text box, automated, efficient, data collection, form elements, properties, text, numbers, barcode, dropdown</remarks>
	/// <release>3.17.2</release>
	SmartForm = 60059,

	/// <summary>Smart Tree Link Chart Layout</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial analysis, data, data model</remarks>
	/// <release>3.23.6</release>
	SmartTreeLinkChartLayout = 60060,

	/// <summary>Smile</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.0, generic, happy, satisfied, satisfaction, face, emoji, like</remarks>
	/// <release>3.16.0</release>
	Smile = 60061,

	/// <summary>Snap To Grid</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.16.5, drawing, snapping, magnet</remarks>
	/// <release>3.16.5</release>
	SnapToGrid = 60062,

	/// <summary>Snap To Point</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.16.5, drawing, snap to object, vectors</remarks>
	/// <release>3.16.5</release>
	SnapToPoint = 60063,

	/// <summary>Snow</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, freezing, stormy</remarks>
	/// <release>3.17.6</release>
	Snow = 60064,

	/// <summary>Snow Thunder</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 3.17.6, generic, clouds, weather, sky, forecast, temperature, environment, nature, precipitation, freezing, stormy, severe weather</remarks>
	/// <release>3.17.6</release>
	SnowThunder = 60065,

	/// <summary>Sort Ascending</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, sort ascending</remarks>
	/// <release>1.5</release>
	SortAscending = 60066,

	/// <summary>Sort Ascending Arrow</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.23.4, lists, sort, ascending, arrow, text, align</remarks>
	/// <release>3.23.4</release>
	SortAscendingArrow = 60067,

	/// <summary>Sort Descending</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, sort descending</remarks>
	/// <release>1.5</release>
	SortDescending = 60068,

	/// <summary>Sort Descending Arrow</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.23.4, lists, sort, descending, arrow, text, align</remarks>
	/// <release>3.23.4</release>
	SortDescendingArrow = 60069,

	/// <summary>Sound</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.6.0, volume, speakers, audio output, loudness, audio input, audio enabled</remarks>
	/// <release>2.6.0</release>
	Sound = 60070,

	/// <summary>Sound Low</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.13.0, generic, volume, speakers, audio output, loudness, audio input, audio enabled, change volume, lower volume, noise</remarks>
	/// <release>3.13.0</release>
	SoundLow = 60071,

	/// <summary>Sound Off</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.6.0, volume, speakers, audio output, quiet, silent, audio input, audio disabled</remarks>
	/// <release>2.6.0</release>
	SoundOff = 60072,

	/// <summary>Sound Unavailable</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.7.0, sound unavailable, sound x, sound broken</remarks>
	/// <release>3.7.0</release>
	SoundUnavailable = 60073,

	/// <summary>Spatiotemporal Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, data, server, storage, group, connection, technology, record</remarks>
	/// <release>3.28.3</release>
	SpatiotemporalDataStore = 60074,

	/// <summary>Speech Bubble</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, speech bubble, comment, chat, message</remarks>
	/// <release>1.5</release>
	SpeechBubble = 60075,

	/// <summary>Speech Bubble Check</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.0, generic, comment, communication, communicate, message, chat, sent, inquiry</remarks>
	/// <release>3.17.0</release>
	SpeechBubbleCheck = 60076,

	/// <summary>Speech Bubble Exclamation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.18.2, generic, speech bubble, comment, thought, chat, message, exclamation mark, emphasis</remarks>
	/// <release>3.18.2</release>
	SpeechBubbleExclamation = 60077,

	/// <summary>Speech Bubble Like</summary>
	/// <remarks>Category: Social Media<br/>
	/// Alias: 3.24.8, social media, like, heart, social media, speech bubble</remarks>
	/// <release>3.24.8</release>
	SpeechBubbleLike = 60078,

	/// <summary>Speech Bubble Plus</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, chat, comment, message, add, speech bubble plus</remarks>
	/// <release>1.5</release>
	SpeechBubblePlus = 60079,

	/// <summary>Speech Bubble Social</summary>
	/// <remarks>Category: Social Media<br/>
	/// Alias: 1.5.0, social-media, social, speech bubble social</remarks>
	/// <release>1.5</release>
	SpeechBubbleSocial = 60080,

	/// <summary>Speech Bubbles</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, chat, comment, message, speech bubbles</remarks>
	/// <release>1.5</release>
	SpeechBubbles = 60081,

	/// <summary>Spinner</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, load, loader, loading</remarks>
	/// <release>1.5</release>
	Spinner = 60082,

	/// <summary>Split</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.0.0, divide</remarks>
	/// <release>3.0.0</release>
	Split = 60083,

	/// <summary>Split Features</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.19.0, gis, shapes, map, area, trim, polygons, cut</remarks>
	/// <release>3.19.0</release>
	SplitFeatures = 60084,

	/// <summary>Split Geometry</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.23.8, geometry editing, cut, splitting, slice, points, lines, shapes, divide</remarks>
	/// <release>3.23.8</release>
	SplitGeometry = 60085,

	/// <summary>Split Units</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.25.2, generic, indoors, dotted lines, units, divide, separate, disconnect, splitting</remarks>
	/// <release>3.25.2</release>
	SplitUnits = 60086,

	/// <summary>Square (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, shapes, box, container, filled</remarks>
	/// <release>1.5</release>
	SquareFilled = 60087,

	/// <summary>Square</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, shapes, box, container</remarks>
	/// <release>1.5</release>
	Square = 60088,

	/// <summary>Square Inset Large</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, square</remarks>
	/// <release>3.28.8</release>
	SquareInsetLarge = 60089,

	/// <summary>Square Inset Medium</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, sqaure</remarks>
	/// <release>3.28.8</release>
	SquareInsetMedium = 60090,

	/// <summary>Square Inset Small</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.8, generic, shape, symbol, square, bold</remarks>
	/// <release>3.28.8</release>
	SquareInsetSmall = 60091,

	/// <summary>Stairs</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, up, down, levels, floors, navigate, navigation</remarks>
	/// <release>1.5</release>
	Stairs = 60092,

	/// <summary>Stairs Down</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.22.1, directions, up, down, levels, floors, navigate, navigation, arrow, below</remarks>
	/// <release>3.22.1</release>
	StairsDown = 60093,

	/// <summary>Stairs Up</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 3.22.1, directions, up, down, levels, floors, navigate, navigation, arrow</remarks>
	/// <release>3.22.1</release>
	StairsUp = 60094,

	/// <summary>Star (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.3.0, symbols, favorite, rate, rating, filled</remarks>
	/// <release>3.3.0</release>
	StarFilled = 60095,

	/// <summary>Star</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.3.0, symbols, favorite, rate, rating</remarks>
	/// <release>3.3.0</release>
	Star = 60096,

	/// <summary>Star Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.3.0, symbols, premium</remarks>
	/// <release>3.3.0</release>
	StarCircle = 60097,

	/// <summary>Stop</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.25.2, symbols, online model builder, stopping, slow, stopped, hold</remarks>
	/// <release>3.25.2</release>
	Stop = 60098,

	/// <summary>Stop Square (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.24.1, media, cube, stop, halt, end, finish, filled</remarks>
	/// <release>3.24.1</release>
	StopSquareFilled = 60099,

	/// <summary>Stop Square</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.24.1, media, cube, stop, halt, end, finish</remarks>
	/// <release>3.24.1</release>
	StopSquare = 60100,

	/// <summary>Storage</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.24.5, gis, data, data bin, data store, data storage</remarks>
	/// <release>3.24.5</release>
	Storage = 60101,

	/// <summary>Stored As New Query</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.8, gis, searching, storing, data, database canister, sparkle, magnifying glass, zoom, magnify, information, storage box, data types</remarks>
	/// <release>3.25.8</release>
	StoredAsNewQuery = 60102,

	/// <summary>Stored Query</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.8, gis, searching, storing, storage box, data, database canister, magnifying glass, zoom, magnify, information, data types</remarks>
	/// <release>3.25.8</release>
	StoredQuery = 60103,

	/// <summary>Straight</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, forward, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	Straight = 60104,

	/// <summary>Stretch</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.23.8, geometry editing, extend, expand, edges, stretching, arrows, lines, shapes, squares, parameters</remarks>
	/// <release>3.23.8</release>
	Stretch = 60105,

	/// <summary>Strikethrough</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.22.6, text, s, cross out, cut, x-out, delete, omit, remove, eliminate, line, edit, formatting, void</remarks>
	/// <release>3.22.6</release>
	Strikethrough = 60106,

	/// <summary>String</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 2.5.3, datatype, text, abc, alphabet, type, letters</remarks>
	/// <release>2.5.3</release>
	String = 60107,

	/// <summary>Sub Fields</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 3.28.1, forms, items, elements, fields, table, levels</remarks>
	/// <release>3.28.1</release>
	SubFields = 60108,

	/// <summary>Subheading</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.3.0, text, sub heading, subheader</remarks>
	/// <release>3.3.0</release>
	Subheading = 60109,

	/// <summary>Subheading 1</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.21.7, text, heading, subheading, layout, title, words, list, bold text, large text, numbers</remarks>
	/// <release>3.21.7</release>
	Subheading1 = 60110,

	/// <summary>Subheading 2</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.21.7, text, heading, subheading, layout, title, words, list, bold text, large text, numbers</remarks>
	/// <release>3.21.7</release>
	Subheading2 = 60111,

	/// <summary>Subheading 3</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.21.7, text, heading, subheading, layout, title, words, list, bold text, large text, numbers</remarks>
	/// <release>3.21.7</release>
	Subheading3 = 60112,

	/// <summary>Subheading 4</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.21.7, text, heading, subheading, layout, title, words, list, bold text, large text, numbers</remarks>
	/// <release>3.21.7</release>
	Subheading4 = 60113,

	/// <summary>Subheading 5</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.21.7, Text, heading, subheading, layout, title, words, list, bold text, large text, numbers</remarks>
	/// <release>3.21.7</release>
	Subheading5 = 60114,

	/// <summary>Subheading Rtl</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.7.0, text, sub heading, subheader</remarks>
	/// <release>3.7.0</release>
	SubheadingRtl = 60115,

	/// <summary>Submit</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 2.5.4, arrow, send, review</remarks>
	/// <release>2.5.4</release>
	Submit = 60116,

	/// <summary>Subscript</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: text, 3.17.3, copy, letter, character, type, format, alignment</remarks>
	/// <release>3.17.3</release>
	Subscript = 60117,

	/// <summary>Subtype</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 3.27.8, charts and graphs, data, type, subordinate, secondary, form</remarks>
	/// <release>3.27.8</release>
	Subtype = 60118,

	/// <summary>Summary</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Summary = 60119,

	/// <summary>Superscript</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: text, 3.17.3, copy, letter, character, type, format, alignment</remarks>
	/// <release>3.17.3</release>
	Superscript = 60120,

	/// <summary>Surface</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.6, gis, wireframe, search, discover, bathymetry, mountain, wire, 3d, perspective, landscape</remarks>
	/// <release>3.25.6</release>
	Surface = 60121,

	/// <summary>Survey</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.1, objects, check mark, clipboard, exam, analysis, audit, inquiry, inspection, review, study, interview</remarks>
	/// <release>3.18.1</release>
	Survey = 60122,

	/// <summary>Switch</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 1.5.0, lists, up down, arrow, items, flip, reverse, sort</remarks>
	/// <release>1.5</release>
	Switch = 60123,

	/// <summary>System Management</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.15.2, generic, settings, manage, tools, wrench, window, options, list, menu</remarks>
	/// <release>3.15.2</release>
	SystemManagement = 60124,

	/// <summary>Tabbed View</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: Lists, 3.16.5, tabs, bullet points, bulleted lists, list items, switch view</remarks>
	/// <release>3.16.5</release>
	TabbedView = 60125,

	/// <summary>Table</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, data, chart, tabular, fields</remarks>
	/// <release>1.5</release>
	Table = 60126,

	/// <summary>Tables</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.4.0, generic, data, chart, tabular, fields</remarks>
	/// <release>3.4.0</release>
	Tables = 60127,

	/// <summary>Tablet</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.6.0, Android, iOS, iPad</remarks>
	/// <release>1.6</release>
	Tablet = 60128,

	/// <summary>Tag</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, label</remarks>
	/// <release>1.5</release>
	Tag = 60129,

	/// <summary>Take Pedestrian Ramp</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, person, walking, navigate, navigation</remarks>
	/// <release>1.5</release>
	TakePedestrianRamp = 60130,

	/// <summary>Templates</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 3.27.0, lists, items, create, lines</remarks>
	/// <release>3.27.0</release>
	Templates = 60131,

	/// <summary>Terminal</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.17.8, window, operating system, programming languages, coding, developer, command line, bash, shell, scripts</remarks>
	/// <release>3.17.8</release>
	Terminal = 60132,

	/// <summary>Territory Buffer Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.18.9, gis, map, area, measure, overlap</remarks>
	/// <release>3.18.9</release>
	TerritoryBufferDistance = 60133,

	/// <summary>Test Data</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.19.1, generic, script, search, test, testing, review, scroll, code, check mark, find</remarks>
	/// <release>3.19.1</release>
	TestData = 60134,

	/// <summary>Text</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Text = 60135,

	/// <summary>Text Bold</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.26.9, text, letter</remarks>
	/// <release>3.26.9</release>
	TextBold = 60136,

	/// <summary>Text Button</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.23.2, text, button, letter, fill, A, box, words, type, layout</remarks>
	/// <release>3.23.2</release>
	TextButton = 60137,

	/// <summary>Text Dashed Underline</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.23.2, text, button, letter, A, line, words, type, layout</remarks>
	/// <release>3.23.2</release>
	TextDashedUnderline = 60138,

	/// <summary>Text Large</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.7.0, text large, large text, large type</remarks>
	/// <release>3.7.0</release>
	TextLarge = 60139,

	/// <summary>Text Medium</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.7.0, text medium, medium text, medium type</remarks>
	/// <release>3.7.0</release>
	TextMedium = 60140,

	/// <summary>Text Paragraph Large</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.10.0, text paragraph large, large body text</remarks>
	/// <release>3.10.0</release>
	TextParagraphLarge = 60141,

	/// <summary>Text Small</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.7.0, text small, body text, smaller type, caption</remarks>
	/// <release>3.7.0</release>
	TextSmall = 60142,

	/// <summary>Text Solid Underline</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.23.2, text, button, letter, A, line, words, type, layout, solid</remarks>
	/// <release>3.23.2</release>
	TextSolidUnderline = 60143,

	/// <summary>Thumbs Down</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.9, generic, disapproval, dislike, unhappy, rating, feedback, unhelpful, hand, reject, fail, dissatisfied, disapprove</remarks>
	/// <release>3.16.9</release>
	ThumbsDown = 60144,

	/// <summary>Thumbs Up</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.14.0, generic, thumbs up, hand, satisfied, like, satisfactory, encouragement, yes, approve, pass, verify, positive</remarks>
	/// <release>3.14.0</release>
	ThumbsUp = 60145,

	/// <summary>Tile Cache Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.28.3, gis, gis database, storage, stored, technology, 3d, three dimensional</remarks>
	/// <release>3.28.3</release>
	TileCacheDataStore = 60146,

	/// <summary>Tile Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.2, layers, tile layer, gis, map layer</remarks>
	/// <release>3.25.2</release>
	TileLayer = 60147,

	/// <summary>Time Filter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.5, clock, gis, watch, screen</remarks>
	/// <release>3.25.5</release>
	TimeFilter = 60148,

	/// <summary>Timer</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects</remarks>
	/// <release>1.5</release>
	Timer = 60149,

	/// <summary>Title</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Title = 60150,

	/// <summary>Toggle</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.2, generic, toggles, on-off, choice, choose, button, enable, disable, switch</remarks>
	/// <release>3.16.2</release>
	Toggle = 60151,

	/// <summary>Toggle Off</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.2, generic, toggles, on-off, choice, choose, button, enable, disable, switch</remarks>
	/// <release>3.16.2</release>
	ToggleOff = 60152,

	/// <summary>Toggle On</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.16.2, generic, toggles, on-off, choice, choose, button, enable, disable, switch</remarks>
	/// <release>3.16.2</release>
	ToggleOn = 60153,

	/// <summary>Tool History</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, history, time, past, action, tool</remarks>
	/// <release>3.32.0</release>
	ToolHistory = 60154,

	/// <summary>Touch</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.8, generic, hand, screen, technology, click, move</remarks>
	/// <release>3.17.8</release>
	Touch = 60155,

	/// <summary>Tour</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.3.0, storymaps, map pins, routing, directions, a to b</remarks>
	/// <release>3.3.0</release>
	Tour = 60156,

	/// <summary>Tour Pin Tear</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.1, gis, location, map pin, map marker, destination, dropped pin, drop pin</remarks>
	/// <release>3.16.1</release>
	TourPinTear = 60157,

	/// <summary>Trace</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 3.25.2, geometry editing, web editor, tracing, edges, lines, points, angles, cover</remarks>
	/// <release>3.25.2</release>
	Trace = 60158,

	/// <summary>Trace Path</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.29.4, gis, tracing, lines, points, edges, path, copy</remarks>
	/// <release>3.29.4</release>
	TracePath = 60159,

	/// <summary>Trace Path Complete</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.29.4, gis, lines, path, completion, edges, points, tracing</remarks>
	/// <release>3.29.4</release>
	TracePathComplete = 60160,

	/// <summary>Transcript (Filled)</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.29.3, media, captions, text, video, display, speech, filled</remarks>
	/// <release>3.29.3</release>
	TranscriptFilled = 60161,

	/// <summary>Transcript</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.29.3, media, captions, text, video, display, speech</remarks>
	/// <release>3.29.3</release>
	Transcript = 60162,

	/// <summary>Transverse Hexagon</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.22.9, gis, shapes, map, area, angles, pattern, tile, square, indexing, coordinates, resolution, datasets, precision</remarks>
	/// <release>3.22.9</release>
	TransverseHexagon = 60163,

	/// <summary>Trash</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.15.1, objects, delete, remove</remarks>
	/// <release>1.5</release>
	Trash = 60164,

	/// <summary>Triangle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.20.5, symbols, shapes, single shape, geometry, glyphs, generic</remarks>
	/// <release>3.20.5</release>
	Triangle = 60165,

	/// <summary>Trucking Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, travel, drive, car, vehicle, route, length, measure, navigate, arrows, destination, traffic, delivery, tracking</remarks>
	/// <release>3.16.8</release>
	TruckingDistance = 60166,

	/// <summary>Trucking Time</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, travel, drive, car, vehicle, timer, deliver, clock, arrival, traffic, tracking</remarks>
	/// <release>3.16.8</release>
	TruckingTime = 60167,

	/// <summary>U Turn</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, u turn, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	UTurn = 60168,

	/// <summary>U Turn Right</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, u turn, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	UTurnRight = 60169,

	/// <summary>Underline</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 1.5.0, text</remarks>
	/// <release>1.5</release>
	Underline = 60170,

	/// <summary>Undo</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 3.15.1, arrows, go back, backwards</remarks>
	/// <release>1.5</release>
	Undo = 60171,

	/// <summary>Ungroup Items</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.17.4, ungroup, shapes, items, unrelease, artboard</remarks>
	/// <release>3.17.4</release>
	UngroupItems = 60172,

	/// <summary>Ungroup Layers</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.25.9, layers, layer stack, off, slash, set</remarks>
	/// <release>3.25.9</release>
	UngroupLayers = 60173,

	/// <summary>Ungroup Layout Elements</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: Generic, 3.17.4, ungroup, shapes, items, unrelease, artboard</remarks>
	/// <release>3.17.4</release>
	UngroupLayoutElements = 60174,

	/// <summary>Unlink</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, chain</remarks>
	/// <release>1.5</release>
	Unlink = 60175,

	/// <summary>Unlock</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, unsecure, unguarded, permission, unrestricted</remarks>
	/// <release>1.5</release>
	Unlock = 60176,

	/// <summary>Unmerge</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.23.1, generic, unmerging, disconnect, separate, split, arrows</remarks>
	/// <release>3.23.1</release>
	Unmerge = 60177,

	/// <summary>Unpin</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.19.5, objects, tack, save, mark, undo, release, slash, pushpin, join, stick</remarks>
	/// <release>3.19.5</release>
	Unpin = 60178,

	/// <summary>Unregister</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.20.1, generic, information, labeling, incorrect, disapproved</remarks>
	/// <release>3.20.1</release>
	Unregister = 60179,

	/// <summary>Unselected</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.25.2, gis, generic, unselection, selection, deselect</remarks>
	/// <release>3.25.2</release>
	Unselected = 60180,

	/// <summary>Update Features</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.22.4, layers, maps, gis, mapping, location, data, feature layers, replace, update, refresh</remarks>
	/// <release>3.22.4</release>
	UpdateFeatures = 60181,

	/// <summary>Update Project</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.23.4, objects, briefcase, arrows, portfolio case, refresh, update, projects</remarks>
	/// <release>3.23.4</release>
	UpdateProject = 60182,

	/// <summary>Upload</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, arrows, export</remarks>
	/// <release>1.5</release>
	Upload = 60183,

	/// <summary>Upload To</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, export</remarks>
	/// <release>1.5</release>
	UploadTo = 60184,

	/// <summary>Urban Model</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 2.8.0, buildings, structures, urban model, item type, skyline, skyscraper, 3d model, cityscape</remarks>
	/// <release>2.8.0</release>
	UrbanModel = 60185,

	/// <summary>Usb Security Key</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.20.9, objects, password, private, secure, access, lock, unlock, protected, admin, permission, restricted, flash drive, data, storage</remarks>
	/// <release>3.20.9</release>
	UsbSecurityKey = 60186,

	/// <summary>User</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people</remarks>
	/// <release>1.5</release>
	User = 60187,

	/// <summary>User Calendar</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.23.9, people, person, users, date, calendars, day, event, time, month, year</remarks>
	/// <release>3.23.9</release>
	UserCalendar = 60188,

	/// <summary>User Down</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.18.6, people, demoted, lower, level</remarks>
	/// <release>3.18.6</release>
	UserDown = 60189,

	/// <summary>User Key</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.18.6, people, role, level, main, value</remarks>
	/// <release>3.18.6</release>
	UserKey = 60190,

	/// <summary>User Minus</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.18.6, people, level, delete, remove, withdraw</remarks>
	/// <release>3.18.6</release>
	UserMinus = 60191,

	/// <summary>User Plus</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people, add user</remarks>
	/// <release>1.5</release>
	UserPlus = 60192,

	/// <summary>User To Device</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people</remarks>
	/// <release>1.5</release>
	UserToDevice = 60193,

	/// <summary>User Up</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.18.6, people, level, higher, level, promoted, promotion</remarks>
	/// <release>3.18.6</release>
	UserUp = 60194,

	/// <summary>User X</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.18.6, people, level, delete, remove, user</remarks>
	/// <release>3.18.6</release>
	UserX = 60195,

	/// <summary>Users</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people, group</remarks>
	/// <release>1.5</release>
	Users = 60196,

	/// <summary>Utility Network</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.0, generic, networking, points, dots, lines, circles, connected, connection, selection, collecting data, running analysis</remarks>
	/// <release>3.28.0</release>
	UtilityNetwork = 60197,

	/// <summary>Utility Network Trace</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.18.6, generic, points, dots, lines, circles, geometric quantitative, network, connected, connection, selection, collecting data, running analysis</remarks>
	/// <release>3.18.6</release>
	UtilityNetworkTrace = 60198,

	/// <summary>Validate</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.32.0, symbols, check, circle, validated, arrow, complete</remarks>
	/// <release>3.32.0</release>
	Validate = 60199,

	/// <summary>Validate Utility Network Topology</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.28.0, generic, networking, points, dots, lines, circles, connected, connection, selection, collecting data, running analysis, confirm, check, approved, validated</remarks>
	/// <release>3.28.0</release>
	ValidateUtilityNetworkTopology = 60200,

	/// <summary>Vertex Check</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.2, check mark, confirm, drawing, draw vertices</remarks>
	/// <release>2.3.2</release>
	VertexCheck = 60201,

	/// <summary>Vertex Edit</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.2, pencil, vertices</remarks>
	/// <release>2.3.4</release>
	VertexEdit = 60202,

	/// <summary>Vertex Gps</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.4, location, vertices</remarks>
	/// <release>2.3.4</release>
	VertexGps = 60203,

	/// <summary>Vertex Move</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.4, pan, vertices</remarks>
	/// <release>2.3.4</release>
	VertexMove = 60204,

	/// <summary>Vertex Plus</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 2.3.4, add, vertices</remarks>
	/// <release>2.3.4</release>
	VertexPlus = 60205,

	/// <summary>Vertex X</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 1.5.0, remove, delete, vertices</remarks>
	/// <release>1.5</release>
	VertexX = 60206,

	/// <summary>Vertical Distribute</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.2, boxes, UI, interface, align, line up, middle, center, central alignment</remarks>
	/// <release>3.17.2</release>
	VerticalDistribute = 60207,

	/// <summary>Video</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.13.0, media, camera, video camera, film camera, record, clip, mp4, motion, tape, watch, add video, upload video, record video</remarks>
	/// <release>3.13.0</release>
	Video = 60208,

	/// <summary>Video Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 3.27.5, layers, video, media, images, picture, media, file, feature</remarks>
	/// <release>3.27.5</release>
	VideoLayer = 60209,

	/// <summary>Video Plus</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.13.0, media, camera, video camera, film camera, record, clip, mp4, motion, tape, watch, add video, upload video, record video, plus</remarks>
	/// <release>3.13.0</release>
	VideoPlus = 60210,

	/// <summary>Video Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.8, gis, connected, connection, play, media, host</remarks>
	/// <release>3.21.8</release>
	VideoServer = 60211,

	/// <summary>Video Single Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.21.8, gis, connected, connection, play, media, host</remarks>
	/// <release>3.21.8</release>
	VideoSingleServer = 60212,

	/// <summary>Video Web</summary>
	/// <remarks>Category: Media<br/>
	/// Alias: 3.3.0, web video, video web, play video, web player, media file, mp4, embedded video</remarks>
	/// <release>3.3.0</release>
	VideoWeb = 60213,

	/// <summary>View Associations</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.22.2, gis, network, connected, circles, dashes, connectivity, connection, grid</remarks>
	/// <release>3.22.2</release>
	ViewAssociations = 60214,

	/// <summary>View Hide</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.6.5, generic, not visible, hidden, unhide, invisible, not shown, eye</remarks>
	/// <release>1.6.5</release>
	ViewHide = 60215,

	/// <summary>View Mixed</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.6.5, generic, covered, hidden, eye, not shown, not in view, visible</remarks>
	/// <release>1.6.5</release>
	ViewMixed = 60216,

	/// <summary>View Visible</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.6.5, eye, generic, shown, preview, visible, unhide, sight, see</remarks>
	/// <release>1.6.5</release>
	ViewVisible = 60217,

	/// <summary>Walk Through Door</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 1.5.0, directions, walk, navigate, navigation, arrow</remarks>
	/// <release>1.5</release>
	WalkThroughDoor = 60218,

	/// <summary>Walking</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, people, person, commute, commuting, activity, transportation</remarks>
	/// <release>1.5</release>
	Walking = 60219,

	/// <summary>Walking Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, hike, travel, route, length, measure, navigate, arrows, destination, arrival, eta</remarks>
	/// <release>3.16.8</release>
	WalkingDistance = 60220,

	/// <summary>Walking Time</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.16.8, gis, hike, route, travel, length, measure, navigate, arrows, arrival, destination, eta</remarks>
	/// <release>3.16.8</release>
	WalkingTime = 60221,

	/// <summary>Web</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, globe, global, internet, www, website, webpage</remarks>
	/// <release>1.5</release>
	Web = 60222,

	/// <summary>Web Adaptor</summary>
	WebAdaptor = 60223,

	/// <summary>Webhook</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.14.0, symbols, web hook, event, information, manage, create, http request, payload, application, push</remarks>
	/// <release>3.14.0</release>
	Webhook = 60224,

	/// <summary>Wheelchair</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 1.5.0, disabled, handicapped, people, person, disability, activity, sport</remarks>
	/// <release>1.5</release>
	Wheelchair = 60225,

	/// <summary>Widgets Group</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, operations dashboard</remarks>
	/// <release>1.5</release>
	WidgetsGroup = 60226,

	/// <summary>Widgets Source</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 1.5.0, charts-and-graphs, interact, connection, connectivity, network, workflow, port, flow-chart, hierarchy</remarks>
	/// <release>1.5</release>
	WidgetsSource = 60227,

	/// <summary>Widgets Tabs</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 1.5.0, windows, operations dashboard</remarks>
	/// <release>1.5</release>
	WidgetsTabs = 60228,

	/// <summary>Wifi</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.17.0, generic, radar, connect, wifi, rays, internet of things, iot, signal, communication</remarks>
	/// <release>3.17.0</release>
	Wifi = 60229,

	/// <summary>Workflow Diagram</summary>
	/// <remarks>Category: Charts and Graphs<br/>
	/// Alias: 2.3.5, hierarchy, control flow, organization, process</remarks>
	/// <release>2.3.5</release>
	WorkflowDiagram = 60230,

	/// <summary>Workflow Manager Server</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.20.7, gis, flow, connections, network, servers, organization, brand, products</remarks>
	/// <release>3.20.7</release>
	WorkflowManagerServer = 60231,

	/// <summary>Wrench</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, build, create, construct</remarks>
	/// <release>1.5</release>
	Wrench = 60232,

	/// <summary>X</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 1.5.0, symbols, delete, remove, close</remarks>
	/// <release>1.5</release>
	X = 60233,

	/// <summary>X Axis Guide</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: chart, style, drawing, dotted line</remarks>
	/// <release>3.2.0</release>
	XAxisGuide = 60234,

	/// <summary>X Bar</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.1.0, sample mean, average, arithmetic mean, x bar, mathematics, formula</remarks>
	/// <release>3.1.0</release>
	XBar = 60235,

	/// <summary>X Circle (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.8.1, symbols, delete, remove, close, filled</remarks>
	/// <release>3.8.1</release>
	XCircleFilled = 60236,

	/// <summary>X Circle</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.8.1, symbols, delete, remove, close</remarks>
	/// <release>3.8.1</release>
	XCircle = 60237,

	/// <summary>X Octagon (Filled)</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.11.0, x octagon, invalid, error, broken, critical, denied, restricted, filled</remarks>
	/// <release>3.11.0</release>
	XOctagonFilled = 60238,

	/// <summary>X Octagon</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.11.0, x octagon, invalid, error, broken, critical, denied, restricted</remarks>
	/// <release>3.11.0</release>
	XOctagon = 60239,

	/// <summary>Y Axis Guide</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: chart, style, drawing, dotted line</remarks>
	/// <release>3.2.0</release>
	YAxisGuide = 60240,

	/// <summary>Zoom In Fixed</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, scale, level of detail, lod, focus, re-adjust, readjust, increments, view</remarks>
	/// <release>1.5</release>
	ZoomInFixed = 60241,

	/// <summary>Zoom Out Fixed</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, scale, level of detail, lod, focus, re-adjust, readjust, increments, view</remarks>
	/// <release>1.5</release>
	ZoomOutFixed = 60242,

	/// <summary>Zoom To Object</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, scale, level of detail, lod, focus, re-adjust, readjust, view, target</remarks>
	/// <release>1.5</release>
	ZoomToObject = 60243,

	/// <summary>3D Building</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.32.0, objects, three dimesional, infrastructure</remarks>
	/// <release>3.32.0</release>
	_3DBuilding = 60244,

	/// <summary>3D Building Parameter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, three dimensional, building, infrastructure, parameter, text, parantheses</remarks>
	/// <release>3.32.0</release>
	_3DBuildingParameter = 60245,

	/// <summary>Browser Map</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.20.3, windows, os, map, location, desktop, layout, web map, application, mapping software</remarks>
	/// <release>3.20.3</release>
	BrowserMap = 60246,

	/// <summary>Buffer Point</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.33.0, gis, point, dot, circles, area, location, cushion, shield, shock, range, space, expanse, sphere, round</remarks>
	/// <release>3.33.0</release>
	BufferPoint = 60247,

	/// <summary>Buffer Polyline</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.33.0, gis, line, area, location, cushion, shield, shock, range, space, expanse, intersection, offset, outline</remarks>
	/// <release>3.33.0</release>
	BufferPolyline = 60248,

	/// <summary>Contour</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.33.0, gis, contour map, topographic, relief map, lines, height, curve, deliniation, outline, profile</remarks>
	/// <release>3.33.0</release>
	Contour = 60249,

	/// <summary>Dashboard Graph</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 3.32.0, windows, measure, objects, statistics, measurements</remarks>
	/// <release>3.32.0</release>
	DashboardGraph = 60250,

	/// <summary>Divide</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 3.32.0, symbols, sign, math, split, halve, cut</remarks>
	/// <release>3.32.0</release>
	Divide = 60251,

	/// <summary>Download</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 1.5.0, generic, cloud, arrow, import</remarks>
	/// <release>1.5</release>
	Download = 60252,

	/// <summary>Drag Resize Horizontal</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.33.0, generic, dragging, resize, resizing, length, direction, panels, sidebar, horizontally</remarks>
	/// <release>3.33.0</release>
	DragResizeHorizontal = 60253,

	/// <summary>Drag Resize Vertical</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 3.33.0, generic, dragging, resize, resizing, height, direction, panels, sidebar, vertically</remarks>
	/// <release>3.33.0</release>
	DragResizeVertical = 60254,

	/// <summary>Initiative Template</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 3.18.1, objects, summit, mountain, flag, goals, tent, camp, achievement, target, objectives, climb, plan project, list, item, pattern</remarks>
	/// <release>3.18.1</release>
	InitiativeTemplate = 60255,

	/// <summary>N Variable</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 3.32.0, text, variables, math, calculation, letter</remarks>
	/// <release>3.32.0</release>
	NVariable = 60256,

	/// <summary>Offset</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.33.0, gis, dashed, expand, line, area, location, cushion, shield, shock, range, space, expanse, intersection, outline</remarks>
	/// <release>3.33.0</release>
	Offset = 60257,

	/// <summary>Parcel</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, features, assets, data, points, lines</remarks>
	/// <release>3.32.0</release>
	Parcel = 60258,

	/// <summary>Parcel Parameter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, feature, data, points, lines, assets</remarks>
	/// <release>3.32.0</release>
	ParcelParameter = 60259,

	/// <summary>Portal Other</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.33.0, gis, layers, data, reference, enterprise</remarks>
	/// <release>3.33.0</release>
	PortalOther = 60260,

	/// <summary>Radial Tree Link Chart Layout</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 3.23.6, knowledge graph, link chart, spatial analysis, data, data model</remarks>
	/// <release>3.23.6</release>
	RadialTreeLinkChartLayout = 60261,

	/// <summary>Refresh</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 1.5.0, arrows, reload, sync</remarks>
	/// <release>1.5</release>
	Refresh = 60262,

	/// <summary>Spaces</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, lines, grid, workspace, work mode</remarks>
	/// <release>3.32.0</release>
	Spaces = 60263,

	/// <summary>Spaces Parameter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, forms, display, space, text</remarks>
	/// <release>3.32.0</release>
	SpacesParameter = 60264,

	/// <summary>Square Brackets X</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, code, syntax, script, text, letter</remarks>
	/// <release>3.32.0</release>
	SquareBracketsX = 60265,

	/// <summary>User Risk</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 3.33.0, people, risk, population, caution, danger, user</remarks>
	/// <release>3.33.0</release>
	UserRisk = 60266,

	/// <summary>Web Adapter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, web, diagram, nodes, storage, servers, transfer</remarks>
	/// <release>3.32.0</release>
	WebAdapter = 60267,

	/// <summary>Zoning Parameter</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 3.32.0, gis, forms, variable, text, letter</remarks>
	/// <release>3.32.0</release>
	ZoningParameter = 60268,

	/// <summary>2D</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 4.0.0, numbers, flat</remarks>
	/// <release>4.0.0</release>
	_2D = 60269,

	/// <summary>3D</summary>
	/// <remarks>Category: Numbers<br/>
	/// Alias: 4.0.0, numbers, interactive</remarks>
	/// <release>4.0.0</release>
	_3D = 60270,

	/// <summary>Area Hash Filled Plus</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.0.0, generic, add, adding, select, selected, construction, space</remarks>
	/// <release>4.0.0</release>
	AreaHashFilledPlus = 60271,

	/// <summary>Area Hash Filled</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.0.0, generic, select, selected, construction, space</remarks>
	/// <release>4.0.0</release>
	AreaHashFilled = 60272,

	/// <summary>Bulldozer Area</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, dirt, construction, building, deconstruction, mover</remarks>
	/// <release>4.0.0</release>
	BulldozerArea = 60273,

	/// <summary>Bulldozer</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, dirt, construction, building, deconstruction, mover</remarks>
	/// <release>4.0.0</release>
	Bulldozer = 60274,

	/// <summary>Bus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, transportation, public transit, vehicle</remarks>
	/// <release>4.0.0</release>
	Bus = 60275,

	/// <summary>Circle Area Hash Filled</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, select, map, area</remarks>
	/// <release>4.0.0</release>
	CircleAreaHashFilled = 60276,

	/// <summary>Cube Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, 3d, add, interactive</remarks>
	/// <release>4.0.0</release>
	CubePlus = 60277,

	/// <summary>Government Building</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.0.0, generic, place, architecture, place</remarks>
	/// <release>4.0.0</release>
	GovernmentBuilding = 60278,

	/// <summary>Layout Duplicate</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.0.0, generic, object, multiply</remarks>
	/// <release>4.0.0</release>
	LayoutDuplicate = 60279,

	/// <summary>Medical</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 4.0.0, symbols, pharmacy, health, cross, medicine</remarks>
	/// <release>4.0.0</release>
	Medical = 60280,

	/// <summary>Money</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 4.0.0, symbols, cash, finance</remarks>
	/// <release>4.0.0</release>
	Money = 60281,

	/// <summary>Person View</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 4.0.0, people, interactive, interacting, 3d, rotate</remarks>
	/// <release>4.0.0</release>
	PersonView = 60282,

	/// <summary>Pie Chart Section Hash Filled</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, graph, selected, area</remarks>
	/// <release>4.0.0</release>
	PieChartSectionHashFilled = 60283,

	/// <summary>Shapes 2D 3D</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, cube, pyramid, circle, objects</remarks>
	/// <release>4.0.0</release>
	Shapes2D3D = 60284,

	/// <summary>Soccer</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, activities, sports, ball, activity</remarks>
	/// <release>4.0.0</release>
	Soccer = 60285,

	/// <summary>Speech Bubble Empty</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.0.0, generic, talk, chat, faq, information</remarks>
	/// <release>4.0.0</release>
	SpeechBubbleEmpty = 60286,

	/// <summary>Square Hash Filled Area</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, duplicate, selected, object, area, construction, map</remarks>
	/// <release>4.0.0</release>
	SquareHashFilledArea = 60287,

	/// <summary>Square Hash Filled</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, select, map, area</remarks>
	/// <release>4.0.0</release>
	SquareHashFilled = 60288,

	/// <summary>Tree</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, landscape, area, park</remarks>
	/// <release>4.0.0</release>
	Tree = 60289,

	/// <summary>Water Drop</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, droplet, h2o</remarks>
	/// <release>4.0.0</release>
	WaterDrop = 60290,

	/// <summary>White Cursor Selection</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, select, map, area</remarks>
	/// <release>4.0.0</release>
	WhiteCursorSelection = 60291,

	/// <summary>Wind</summary>
	/// <remarks>Category: Weather<br/>
	/// Alias: 4.0.0, weather, weather, conditions, forecast</remarks>
	/// <release>4.0.0</release>
	Wind = 60292,

	/// <summary>Uncollapse Relationships</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, nodes</remarks>
	/// <release>4.0.0</release>
	UncollapseRelationships = 61697,

	/// <summary>Uncollapse Entities</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, nodes</remarks>
	/// <release>4.0.0</release>
	UncollapseEntities = 61698,

	/// <summary>Single Timeline</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes, clock, time</remarks>
	/// <release>4.0.0</release>
	SingleTimeline = 61699,

	/// <summary>Show Link Chart Root Nodes</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, view, area, nodes, distance, select, model</remarks>
	/// <release>4.0.0</release>
	ShowLinkChartRootNodes = 61700,

	/// <summary>Show Link Chart Nonspatial Data</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, eye, view, points, model, select, nodes</remarks>
	/// <release>4.0.0</release>
	ShowLinkChartNonspatialData = 61701,

	/// <summary>Show Data</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, view, server, memory</remarks>
	/// <release>4.0.0</release>
	ShowData = 61702,

	/// <summary>Select Root Chart Nodes</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, view, area, nodes, distance, select, model</remarks>
	/// <release>4.0.0</release>
	SelectRootChartNodes = 61703,

	/// <summary>Select Nonspatial Data</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	SelectNonspatialData = 61704,

	/// <summary>Plug Connection</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, connect, power, relation, union, bond, adapter, service</remarks>
	/// <release>4.0.0</release>
	PlugConnection = 61705,

	/// <summary>Multi Timeline</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes, clock, time</remarks>
	/// <release>4.0.0</release>
	MultiTimeline = 61706,

	/// <summary>Link Chart Tools</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, nodes, wrench</remarks>
	/// <release>4.0.0</release>
	LinkChartTools = 61707,

	/// <summary>Link Chart Sync Selection</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartSyncSelection = 61708,

	/// <summary>Link Chart Select Between</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartSelectBetween = 61709,

	/// <summary>Link Chart Find Between</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartFindBetween = 61710,

	/// <summary>Link Chart Connect</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartConnect = 61711,

	/// <summary>Link Chart Connect From</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartConnectFrom = 61712,

	/// <summary>Link Chart Connect Between</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartConnectBetween = 61713,

	/// <summary>Link Chart Collapse Ends</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, close, delete, points, model, select, add to, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartCollapseEnds = 61714,

	/// <summary>Link Chart Centrality</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, calculator, filter, points, model, select, add to, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartCentrality = 61715,

	/// <summary>Link Chart Apply To</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes</remarks>
	/// <release>4.0.0</release>
	LinkChartApplyTo = 61716,

	/// <summary>Hide Link Chart Root Nodes</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, remove, nodes, area, distance</remarks>
	/// <release>4.0.0</release>
	HideLinkChartRootNodes = 61717,

	/// <summary>Hide Link Chart Nonspatial Data</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, remove, nodes</remarks>
	/// <release>4.0.0</release>
	HideLinkChartNonspatialData = 61718,

	/// <summary>Hide Data</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, server, memory</remarks>
	/// <release>4.0.0</release>
	HideData = 61719,

	/// <summary>Find Add Path</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add to, nodes</remarks>
	/// <release>4.0.0</release>
	FindAddPath = 61720,

	/// <summary>Filtered Find Add Path</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, filter, points, model, select, add to, nodes</remarks>
	/// <release>4.0.0</release>
	FilteredFindAddPath = 61721,

	/// <summary>Editing Trim To Length</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, area, nodes, distance, select, model</remarks>
	/// <release>4.0.0</release>
	EditingTrimToLength = 61722,

	/// <summary>Community Detection</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, calculator, filter, points, model, select, add to, nodes</remarks>
	/// <release>4.0.0</release>
	CommunityDetection = 61723,

	/// <summary>Collapse Relationships</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes, simplify, condense</remarks>
	/// <release>4.0.0</release>
	CollapseRelationships = 61724,

	/// <summary>Collapse Entities</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, points, model, select, add, nodes, simplify, condense</remarks>
	/// <release>4.0.0</release>
	CollapseEntities = 61725,

	/// <summary>Cluster Radius</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, area, nodes, distance, select, model</remarks>
	/// <release>4.0.0</release>
	ClusterRadius = 61726,

	/// <summary>Add Link Chart Root Nodes</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.0.0, knowledge graph, filter, points, model, select, add to, nodes, area, distance</remarks>
	/// <release>4.0.0</release>
	AddLinkChartRootNodes = 61727,

	/// <summary>Utility Network Layer</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.0.0, layers, networking, lines, circles, points, dots, connection, connected, running-analysis</remarks>
	/// <release>4.0.0</release>
	UtilityNetworkLayer = 61728,

	/// <summary>Crosshair</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, dot, lines, reticule, scope, target, aim, marker, goal, point</remarks>
	/// <release>4.0.0</release>
	Crosshair = 61729,

	/// <summary>Hammer Lock</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, lock, tool, combination, secure</remarks>
	/// <release>4.0.0</release>
	HammerLock = 61730,

	/// <summary>Hammer Coin</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.0.0, objects, tool, mallet, cash, change, currency</remarks>
	/// <release>4.0.0</release>
	HammerCoin = 61731,

	/// <summary>Dual Image Location</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, location, direction, two, position, site</remarks>
	/// <release>4.0.0</release>
	DualImageLocation = 61732,

	/// <summary>Dual Image Distance</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, distance, two, gap, span, reach</remarks>
	/// <release>4.0.0</release>
	DualImageDistance = 61733,

	/// <summary>Dual Image Area</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.0.0, gis, area, zone, region, two, image</remarks>
	/// <release>4.0.0</release>
	DualImageArea = 61734,

	/// <summary>Language 2</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.0.1, generic, speech, dialect, tongue, vernacular</remarks>
	/// <release>4.0.1</release>
	Language2 = 61735,

	/// <summary>Browser Plus</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 4.1.0, windows, web, add, explore, table</remarks>
	/// <release>4.1.0</release>
	BrowserPlus = 61736,

	/// <summary>Browser Join</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 4.1.0, windows, web, explore, combine, tables</remarks>
	/// <release>4.1.0</release>
	BrowserJoin = 61737,

	/// <summary>Variable Plus</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.1.1, text, add, changeable, fluctating, inconstant</remarks>
	/// <release>4.1.1</release>
	VariablePlus = 61738,

	/// <summary>Table Set</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.1.1, generic, setting, cover, arrangement, columns, features</remarks>
	/// <release>4.1.1</release>
	TableSet = 61739,

	/// <summary>String Set</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.1.1, text, chain, sequence, series, group, collection</remarks>
	/// <release>4.1.1</release>
	StringSet = 61740,

	/// <summary>Parameters</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.1.1, text, framework, limitation, restriction, specification</remarks>
	/// <release>4.1.1</release>
	Parameters = 61741,

	/// <summary>Parameters Plus</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.1.1, text, framework, restriction, guideline, limit</remarks>
	/// <release>4.1.1</release>
	ParametersPlus = 61742,

	/// <summary>Parameters Gear</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.1.1, text, limit, guideline, criteria, tool</remarks>
	/// <release>4.1.1</release>
	ParametersGear = 61743,

	/// <summary>Multiple Variables Set</summary>
	/// <remarks>Category: Symbols<br/>
	/// Alias: 4.1.1, symbols, changeable, many, numbers</remarks>
	/// <release>4.1.1</release>
	MultipleVariablesSet = 61744,

	/// <summary>Map Information</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.1.1, gis, map, guide, instructions</remarks>
	/// <release>4.1.1</release>
	MapInformation = 61745,

	/// <summary>Layer Set</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.1.1, layers, tier, stack, bed, stratum</remarks>
	/// <release>4.1.1</release>
	LayerSet = 61746,

	/// <summary>Double Float Set</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.1.1, text, floating, precision, memory</remarks>
	/// <release>4.1.1</release>
	DoubleFloatSet = 61747,

	/// <summary>Video Learning</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, video, learning, visual, coffee, playback, relax, record, clip, cup, warm</remarks>
	/// <release>4.2.0</release>
	VideoLearning = 61748,

	/// <summary>Storymap Experience</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, web, app, logo, app, product</remarks>
	/// <release>4.2.0</release>
	StorymapExperience = 61749,

	/// <summary>Mooc</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, courses, training, online, graduation, class</remarks>
	/// <release>4.2.0</release>
	Mooc = 61750,

	/// <summary>Learning Web Course</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, learning, web, course, online, virtual, internet, interactive, cloud</remarks>
	/// <release>4.2.0</release>
	LearningWebCourse = 61751,

	/// <summary>Learning Steps</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, learning, plan, steps, workflow, planner, number, chronological</remarks>
	/// <release>4.2.0</release>
	LearningSteps = 61752,

	/// <summary>Learning Gis Workflow</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, learning, gis, lab, workflow, plan, interact, system, roadmap, productivity, map</remarks>
	/// <release>4.2.0</release>
	LearningGisWorkflow = 61753,

	/// <summary>E Learning Gis</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, learning, gis, presenter, online, video, virtual, asynchronous</remarks>
	/// <release>4.2.0</release>
	ELearningGis = 61754,

	/// <summary>Document Learning</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, document, learning, pencil, note, folder, write, class</remarks>
	/// <release>4.2.0</release>
	DocumentLearning = 61755,

	/// <summary>Classroom Gis</summary>
	/// <remarks>Category: Education<br/>
	/// Alias: 4.2.0, education, classroom, gis, presenter, desk, podium, map, teacher</remarks>
	/// <release>4.2.0</release>
	ClassroomGis = 61756,

	/// <summary>Mosaic Method None</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.2.0, gis, nothing, uncombined, unblended, separated, disassembled</remarks>
	/// <release>4.2.0</release>
	MosaicMethodNone = 61757,

	/// <summary>Spike Data Visualization</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.2.0, generic, display, raster, interactive, data</remarks>
	/// <release>4.2.0</release>
	SpikeDataVisualization = 61758,

	/// <summary>Spike Data Visualization Outlined Open</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.2.1, generic, display, raster, interactive, data, outlined, shape, open</remarks>
	/// <release>4.2.1</release>
	SpikeDataVisualizationOutlinedOpen = 61759,

	/// <summary>Spike Data Visualization Outlined (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.2.0, generic, display, raster, interactive, data, filled</remarks>
	/// <release>4.2.0</release>
	SpikeDataVisualizationOutlinedFilled = 61760,

	/// <summary>Spike Data Visualization Open</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.2.0, generic, display, raster, interactive, data, open, shape</remarks>
	/// <release>4.2.0</release>
	SpikeDataVisualizationOpen = 61761,

	/// <summary>Transfer</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 4.2.1, people, move, shift, remove, conduct, transmit</remarks>
	/// <release>4.2.1</release>
	Transfer = 61762,

	/// <summary>Tapestry</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 4.2.1, brand, segmentation, data, classification, group</remarks>
	/// <release>4.2.1</release>
	Tapestry = 61763,

	/// <summary>Spike Data Visualization Outlined Open (Filled)</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.2.1, generic, display, raster, interactive, data, outlined, shape, open, filled</remarks>
	/// <release>4.2.1</release>
	SpikeDataVisualizationOutlinedOpenFilled = 61764,

	/// <summary>Subheading 5 Rtl</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.2.1, text, type, subtitle, script, headline, caption</remarks>
	/// <release>4.2.1</release>
	Subheading5Rtl = 61765,

	/// <summary>Subheading 4 Rtl</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.2.1, text, type, subtitle, script, headline, caption</remarks>
	/// <release>4.2.1</release>
	Subheading4Rtl = 61766,

	/// <summary>Subheading 3 Rtl</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.2.1, text, type, subtitle, script, headline, caption</remarks>
	/// <release>4.2.1</release>
	Subheading3Rtl = 61767,

	/// <summary>Subheading 2 Rtl</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.2.1, text, type, subtitle, script, headline, caption</remarks>
	/// <release>4.2.1</release>
	Subheading2Rtl = 61768,

	/// <summary>Subheading 1 Rtl</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.2.1, text, type, subtitle, script, headline, caption</remarks>
	/// <release>4.2.1</release>
	Subheading1Rtl = 61769,

	/// <summary>Sequential Navigation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, sequence, gps, location, direction</remarks>
	/// <release>4.3.0</release>
	SequentialNavigation = 61770,

	/// <summary>Image Navigation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, gps, image, location, direction</remarks>
	/// <release>4.3.0</release>
	ImageNavigation = 61771,

	/// <summary>Directional Navigation</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, direction, gps, location, instructions</remarks>
	/// <release>4.3.0</release>
	DirectionalNavigation = 61772,

	/// <summary>Content Side By Side Right</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 4.3.0, windows, table, content, html, css</remarks>
	/// <release>4.3.0</release>
	ContentSideBySideRight = 61773,

	/// <summary>Location Label</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, marker, navigation, map, identify, data</remarks>
	/// <release>4.3.0</release>
	LocationLabel = 61774,

	/// <summary>Tangent Curve</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, create, segments, points, circular</remarks>
	/// <release>4.3.0</release>
	TangentCurve = 61775,

	/// <summary>End Point Arc Segment</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, circular, create, typing, define, point</remarks>
	/// <release>4.3.0</release>
	EndPointArcSegment = 61776,

	/// <summary>Bezier Curve</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, nonlinear, create, shape, angle, height</remarks>
	/// <release>4.3.0</release>
	BezierCurve = 61777,

	/// <summary>Arrow Curve Tool</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, tool, map, points, midpoint, line</remarks>
	/// <release>4.3.0</release>
	ArrowCurveTool = 61778,

	/// <summary>Arc Segment</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, create, location, point, radius, pass</remarks>
	/// <release>4.3.0</release>
	ArcSegment = 61779,

	/// <summary>Dimensions Centered</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, alignment, placement, position, settings</remarks>
	/// <release>4.3.0</release>
	DimensionsCentered = 61780,

	/// <summary>Person Magnifying Glass</summary>
	/// <remarks>Category: People<br/>
	/// Alias: 4.3.0, people, launch, preview, information, magnify, user</remarks>
	/// <release>4.3.0</release>
	PersonMagnifyingGlass = 61781,

	/// <summary>Arrow Right 10</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 4.3.0, arrows, skip, ahead, time, scrub, direction</remarks>
	/// <release>4.3.0</release>
	ArrowRight10 = 61782,

	/// <summary>Arrow Left 10</summary>
	/// <remarks>Category: Arrows<br/>
	/// Alias: 4.3.0, arrows, video, direction, scrub, time</remarks>
	/// <release>4.3.0</release>
	ArrowLeft10 = 61783,

	/// <summary>Magic Wand</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, effects, edit, image</remarks>
	/// <release>4.3.0</release>
	MagicWand = 61784,

	/// <summary>Catalog</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, organize, search, content, filter, folders</remarks>
	/// <release>4.3.0</release>
	Catalog = 61785,

	/// <summary>Envelope (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, send, email, contact information, filled</remarks>
	/// <release>1.5</release>
	EnvelopeFilled = 61786,

	/// <summary>Video Data Store</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, publish, enhancements, manage, retrieve</remarks>
	/// <release>4.3.0</release>
	VideoDataStore = 61787,

	/// <summary>Topology</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, spaces, shape, points, math</remarks>
	/// <release>4.3.0</release>
	Topology = 61788,

	/// <summary>Relationship Class</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, store, fields, features, table, geodatabase</remarks>
	/// <release>4.3.0</release>
	RelationshipClass = 61789,

	/// <summary>Range Domain</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, values, output, geodatabase, schema</remarks>
	/// <release>4.3.0</release>
	RangeDomain = 61790,

	/// <summary>Point Along A Line</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, tool, layer, interval, distance</remarks>
	/// <release>4.3.0</release>
	PointAlongALine = 61791,

	/// <summary>Parcel Dataset</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, collection, attributes, information, polygons</remarks>
	/// <release>4.3.0</release>
	ParcelDataset = 61792,

	/// <summary>Midpoint</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, point, divide, segmemt, equal</remarks>
	/// <release>4.3.0</release>
	Midpoint = 61793,

	/// <summary>Line Intersection</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, lines, cross, point, single, angles</remarks>
	/// <release>4.3.0</release>
	LineIntersection = 61794,

	/// <summary>Line And Circle Intersection</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, shape, points, equation, substitue</remarks>
	/// <release>4.3.0</release>
	LineAndCircleIntersection = 61795,

	/// <summary>Layer Multipoint</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.3.0, layers, data-structures, connect, network, geodatabase</remarks>
	/// <release>4.3.0</release>
	LayerMultipoint = 61796,

	/// <summary>Layer Multipatch</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.3.0, layers, collection, boundary, object, geodatabase</remarks>
	/// <release>4.3.0</release>
	LayerMultipatch = 61797,

	/// <summary>Layer Dimension</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.3.0, layers, elements, color, compare, geodatabase,schema</remarks>
	/// <release>4.3.0</release>
	LayerDimension = 61798,

	/// <summary>Layer Annotation</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.3.0, layers, text, visual, label, geodatabase</remarks>
	/// <release>4.3.0</release>
	LayerAnnotation = 61799,

	/// <summary>Intersection</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, points, figures, overlap, cross, line</remarks>
	/// <release>4.3.0</release>
	Intersection = 61800,

	/// <summary>Geometric Network</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, edges, junctions, points, network</remarks>
	/// <release>4.3.0</release>
	GeometricNetwork = 61801,

	/// <summary>Feature Dataset</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, geodatabase, schema, compare, tools</remarks>
	/// <release>4.3.0</release>
	FeatureDataset = 61802,

	/// <summary>Coded Value Domain</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.3.0, gis, geodatabase, schema, compare, tool</remarks>
	/// <release>4.3.0</release>
	CodedValueDomain = 61803,

	/// <summary>Circle Intersection</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, calculate, compare, distance, sum, difference</remarks>
	/// <release>4.3.0</release>
	CircleIntersection = 61804,

	/// <summary>Autocomplete Polygon</summary>
	/// <remarks>Category: Geometry Editing<br/>
	/// Alias: 4.3.0, geometry editing, feature, boundary, shapes, tool</remarks>
	/// <release>4.3.0</release>
	AutocompletePolygon = 61805,

	/// <summary>Assign Classification</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.3.0, generic, presentation, top-secret, protection, unclassified</remarks>
	/// <release>4.3.0</release>
	AssignClassification = 61806,

	/// <summary>List Check Rtl</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 4.3.0, lists, points, read, align, tasks</remarks>
	/// <release>4.3.0</release>
	ListCheckRtl = 61807,

	/// <summary>List Check All Rtl</summary>
	/// <remarks>Category: Lists<br/>
	/// Alias: 4.3.0, lists, points, text, align, read</remarks>
	/// <release>4.3.0</release>
	ListCheckAllRtl = 61808,

	/// <summary>Video Metadata</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, technology, workflow, publishing, feature</remarks>
	/// <release>4.3.0</release>
	VideoMetadata = 61809,

	/// <summary>Security Camera</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, safety, surveillance, monitor, technology</remarks>
	/// <release>4.3.0</release>
	SecurityCamera = 61810,

	/// <summary>Livestream Video Protocols</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, technology, delivery, standardized, rules, data, internet</remarks>
	/// <release>4.3.0</release>
	LivestreamVideoProtocols = 61811,

	/// <summary>Camera Sensor</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, technology, workflow, video, feature</remarks>
	/// <release>4.3.0</release>
	CameraSensor = 61812,

	/// <summary>Camera Sensor Map</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, technology, workflow, video, publish, layers</remarks>
	/// <release>4.3.0</release>
	CameraSensorMap = 61813,

	/// <summary>Camera Sensor Layer</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, technology, workflow, publish, video, feature</remarks>
	/// <release>4.3.0</release>
	CameraSensorLayer = 61814,

	/// <summary>Shopping Cart Plus</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.3.0, objects, items, store, buggy, trolley, basket, add, video</remarks>
	/// <release>4.3.0</release>
	ShoppingCartPlus = 61815,

	/// <summary>Shopping Cart (Filled)</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 1.5.0, objects, purchase, buy, market, items, filled</remarks>
	/// <release>1.5</release>
	ShoppingCartFilled = 61816,

	/// <summary>Carousel Frames</summary>
	/// <remarks>Category: Windows<br/>
	/// Alias: 4.3.0, windows, storytelling, frames, story-maps</remarks>
	/// <release>4.3.0</release>
	CarouselFrames = 61817,

	/// <summary>Layer 3D</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.3.0, layers, 3D-object-layer, building-layer, mesh-layer, point-cloud-layer, gaussian-splat-layer, voxel-layer, point-layer</remarks>
	/// <release>4.3.0</release>
	Layer3D = 61818,

	/// <summary>Mission System Message</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 4.3.0, brand, mobile, web, application, communication, data-exchange</remarks>
	/// <release>4.3.0</release>
	MissionSystemMessage = 61819,

	/// <summary>Number Set</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.3.0, text, formatting, generate, features, data, symbols</remarks>
	/// <release>4.3.0</release>
	NumberSet = 61820,

	/// <summary>Integer Set</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.3.0, text, storing, number, values, raster, fields</remarks>
	/// <release>4.3.0</release>
	IntegerSet = 61821,

	/// <summary>Organize Template</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.4.0, gis, list, field, maps, feature, manage</remarks>
	/// <release>4.4.0</release>
	OrganizeTemplate = 61822,

	/// <summary>Group Template</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.4.0, gis, list, point, entry, field, maps</remarks>
	/// <release>4.4.0</release>
	GroupTemplate = 61823,

	/// <summary>Signal Health</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.4.0, gis, workflow, maintenance, ips, beacon, connectivity</remarks>
	/// <release>4.4.0</release>
	SignalHealth = 61824,

	/// <summary>Group Content</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, collaborate, organize, layers, related, join</remarks>
	/// <release>4.4.0</release>
	GroupContent = 61825,

	/// <summary>Metadata</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 4.4.0, files, information, attribute, type, object, schema, technology, publishing, workflow</remarks>
	/// <release>4.4.0</release>
	Metadata = 61826,

	/// <summary>Relative Direction Arrows</summary>
	/// <remarks>Category: Directions<br/>
	/// Alias: 4.4.0, directions, line, features, symbology, data</remarks>
	/// <release>4.4.0</release>
	RelativeDirectionArrows = 61827,

	/// <summary>Partnered Collaboration</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 4.4.0, brand, share, edit, content, apps, layers</remarks>
	/// <release>4.4.0</release>
	PartneredCollaboration = 61828,

	/// <summary>Open Data</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 4.4.0, brand, dashboards, charts, visualization, feature</remarks>
	/// <release>4.4.0</release>
	OpenData = 61829,

	/// <summary>ArcGIS Solutions</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 4.4.0, brand, data, geospatial, configurations, location</remarks>
	/// <release>4.4.0</release>
	ArcGISSolutions = 61830,

	/// <summary>ArcGIS Living Atlas</summary>
	/// <remarks>Category: Brand<br/>
	/// Alias: 4.4.0, brand, maps, apps, data-layers, collection, imagery</remarks>
	/// <release>4.4.0</release>
	ArcGISLivingAtlas = 61831,

	/// <summary>Star Values</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, unique, analysis, attribute, field, mapping</remarks>
	/// <release>4.4.0</release>
	StarValues = 61832,

	/// <summary>Sort Descending View</summary>
	/// <remarks>Category: List<br/>
	/// Alias: 4.4.0, list, tool, data, table, properties, attribute, dialog</remarks>
	/// <release>4.4.0</release>
	SortDescendingView = 61833,

	/// <summary>Sort Ascending View</summary>
	/// <remarks>Category: List<br/>
	/// Alias: 4.4.0, list, table, sort, data, view, tool</remarks>
	/// <release>4.4.0</release>
	SortAscendingView = 61834,

	/// <summary>Duplicate Values</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, tool, attribute, identify, features</remarks>
	/// <release>4.4.0</release>
	DuplicateValues = 61835,

	/// <summary>Update Table</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, edit, cells, values, attribute, data</remarks>
	/// <release>4.4.0</release>
	UpdateTable = 61836,

	/// <summary>Contingent Values Retire</summary>
	/// <remarks>Category: Forms<br/>
	/// Alias: 4.4.0, forms, combinations, fields, data, historical-records</remarks>
	/// <release>4.4.0</release>
	ContingentValuesRetire = 61837,

	/// <summary>File Esl</summary>
	/// <remarks>Category: Files<br/>
	/// Alias: 4.4.0, files, sensing, image-analysis, content, tool, collections</remarks>
	/// <release>4.4.0</release>
	FileEsl = 61838,

	/// <summary>Table Upload</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, data, collection, web, layer, import, external</remarks>
	/// <release>4.4.0</release>
	TableUpload = 61839,

	/// <summary>Table Download</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, data, format, collection, web, layer, save</remarks>
	/// <release>4.4.0</release>
	TableDownload = 61840,

	/// <summary>Variable Generic</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.4.0, text, values, equations, datasets, general</remarks>
	/// <release>4.4.0</release>
	VariableGeneric = 61841,

	/// <summary>Provenance</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.4.0, knowledge graph, information, graph, knowledge, history, data-lineage</remarks>
	/// <release>4.4.0</release>
	Provenance = 61842,

	/// <summary>Layer Wms</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, url, map, tiles, server, interaction</remarks>
	/// <release>4.4.0</release>
	LayerWms = 61843,

	/// <summary>Layer Wfs</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, vector, data, web, features, format</remarks>
	/// <release>4.4.0</release>
	LayerWfs = 61844,

	/// <summary>Layer Wcs</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, stream, analysis, datasets, satellite, raster</remarks>
	/// <release>4.4.0</release>
	LayerWcs = 61845,

	/// <summary>Layer Vector Tile</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, data, points, styling, basemap, webmap</remarks>
	/// <release>4.4.0</release>
	LayerVectorTile = 61846,

	/// <summary>Layer Subtype Group</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, composite, feature, data, visibility</remarks>
	/// <release>4.4.0</release>
	LayerSubtypeGroup = 61847,

	/// <summary>Layer Stream</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, datasets, real-time, map, tracking, web</remarks>
	/// <release>4.4.0</release>
	LayerStream = 61848,

	/// <summary>Layer Ogc</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, data, web, connection, organization</remarks>
	/// <release>4.4.0</release>
	LayerOgc = 61849,

	/// <summary>Layer Map Notes</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, points, lines, polygons, features, attribute, annotation</remarks>
	/// <release>4.4.0</release>
	LayerMapNotes = 61850,

	/// <summary>Layer Georss</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, display, point, lines, polygons, map</remarks>
	/// <release>4.4.0</release>
	LayerGeorss = 61851,

	/// <summary>Layer Geojson</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, format, encoding, geographic-data, data-structures</remarks>
	/// <release>4.4.0</release>
	LayerGeojson = 61852,

	/// <summary>Layer Csv</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, data, web, tabular, points, file</remarks>
	/// <release>4.4.0</release>
	LayerCsv = 61853,

	/// <summary>Layer Catalog</summary>
	/// <remarks>Category: Layers<br/>
	/// Alias: 4.4.0, layers, local, shared, dataets, collection</remarks>
	/// <release>4.4.0</release>
	LayerCatalog = 61854,

	/// <summary>Knowledge Graph Endpoint</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.4.0, knowledge graph, start, data-model, entities, access</remarks>
	/// <release>4.4.0</release>
	KnowledgeGraphEndpoint = 61855,

	/// <summary>Globally Unique Identifier</summary>
	/// <remarks>Category: Text<br/>
	/// Alias: 4.4.0, text, objects, computer, datasets, systems, tracking</remarks>
	/// <release>4.4.0</release>
	GloballyUniqueIdentifier = 61856,

	/// <summary>Find Path Origin</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.4.0, knowledge graph, network-analysis, points, graph, points, tool</remarks>
	/// <release>4.4.0</release>
	FindPathOrigin = 61857,

	/// <summary>Find Path Include</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.4.0, knowledge graph, data, origin, destination, graph, network</remarks>
	/// <release>4.4.0</release>
	FindPathInclude = 61858,

	/// <summary>Find Path Exclude</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.4.0, knowledge graph, network-analysis, origin, destination, barriers, restrictions</remarks>
	/// <release>4.4.0</release>
	FindPathExclude = 61859,

	/// <summary>Find Path Destination</summary>
	/// <remarks>Category: Knowledge Graph<br/>
	/// Alias: 4.4.0, knowledge graph, endpoint, dataset, analysis, tool</remarks>
	/// <release>4.4.0</release>
	FindPathDestination = 61860,

	/// <summary>Tools</summary>
	/// <remarks>Category: Objects<br/>
	/// Alias: 4.4.0, objects, analyze, wrench, screwdriver, instrument, gadget, device</remarks>
	/// <release>4.4.0</release>
	Tools = 61861,

	/// <summary>Template Group Point At Start</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, feature, vertex, line, distance</remarks>
	/// <release>4.4.0</release>
	TemplateGroupPointAtStart = 61862,

	/// <summary>Template Group Point At Every Vertex</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, features, map, line-builder, tools</remarks>
	/// <release>4.4.0</release>
	TemplateGroupPointAtEveryVertex = 61863,

	/// <summary>Template Group Point At Every Vertex But Start</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, feature, line, offset, tool, attribute</remarks>
	/// <release>4.4.0</release>
	TemplateGroupPointAtEveryVertexButStart = 61864,

	/// <summary>Template Group Point At Centroid</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, feature, polygon, action, mass, boundary</remarks>
	/// <release>4.4.0</release>
	TemplateGroupPointAtCentroid = 61865,

	/// <summary>Template Group Multiple Two Point Lines</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, feature, map, layers, tool</remarks>
	/// <release>4.4.0</release>
	TemplateGroupMultipleTwoPointLines = 61866,

	/// <summary>Template Group Multiple Lines</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, features, sketch, workflows, infrastructure</remarks>
	/// <release>4.4.0</release>
	TemplateGroupMultipleLines = 61867,

	/// <summary>Template Group At Start Of Line</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, function, setting, features, point, vertex</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAtStartOfLine = 61868,

	/// <summary>Template Group At End Of Line</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, configuration, point, feature, data, action</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAtEndOfLine = 61869,

	/// <summary>Template Group At All Vertices</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, vertex, linear-network, boundary</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAtAllVertices = 61870,

	/// <summary>Template Group At All Vertices But Start</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, feature, points, line, connection, layer</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAtAllVerticesButStart = 61871,

	/// <summary>Template Group At All Vertices But Start And End</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, feature, polyline, nodes, polygon</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAtAllVerticesButStartAndEnd = 61872,

	/// <summary>Template Group At All Vertices But End</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, segment, feature, data, points, tool</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAtAllVerticesButEnd = 61873,

	/// <summary>Template Group Along Line</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, features, points, vertices, intervals</remarks>
	/// <release>4.4.0</release>
	TemplateGroupAlongLine = 61874,

	/// <summary>Show Oriented Imagery</summary>
	/// <remarks>Category: GIS<br/>
	/// Alias: 4.4.0, gis, layer, map, point, view, interactive</remarks>
	/// <release>4.4.0</release>
	ShowOrientedImagery = 61875,

	/// <summary>Radial Lines</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, linear-features, point, analysis, mapping</remarks>
	/// <release>4.4.0</release>
	RadialLines = 61876,

	/// <summary>Point At Every Intersection</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, tools, feature, analyze, identify, points</remarks>
	/// <release>4.4.0</release>
	PointAtEveryIntersection = 61877,

	/// <summary>Group Off Set Start Of Line</summary>
	/// <remarks>Category: Template Group<br/>
	/// Alias: 4.4.0, template group, tool, point, feature, distance, place</remarks>
	/// <release>4.4.0</release>
	GroupOffSetStartOfLine = 61878,

	/// <summary>3D Search</summary>
	/// <remarks>Category: Generic<br/>
	/// Alias: 4.4.0, generic, algorithm, data, points, space, location</remarks>
	/// <release>4.4.0</release>
	_3DSearch = 61879,

}
