<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

	<head>

		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<meta http-equiv="imagetoolbar" content="no" />

		<title>cufón - fonts for the people</title>

		<meta name="description" content="Fast text replacement with canvas and VML - no Flash or images required." />

		<link rel="stylesheet" href="css/style.css?v=2" type="text/css" />

		<script src="js/ui.js?v=4" type="text/javascript"></script>

		<script src="../js/cufon.js" type="text/javascript"></script>
		<script src="../fonts/Vegur.font.js" type="text/javascript"></script>

		<script type="text/javascript">

			Cufon('h1', {
				color: '-linear-gradient(#b7dded, 0.2=#70ceef, 0.5=#20b4e2, #b1dbeb)'
			});

			Cufon('h3');

		</script>

	</head>

	<body>

		<div id="doc">

			<div id="page">

				<div id="head">

					<h1><a href="/">cufón - fonts for the people</a></h1>

				</div>

				<div id="nav">

					<ul class="nav">
						<li><a href="http://cufon.shoqolate.com/js/cufon-yui.js?v=1.09i">Download <span class="version">1.09i</span></a></li>
						<li class="current"><a href=".">Generator</a></li>
						<li><a href="http://github.com/sorccu/cufon/wikis" class="external">Documentation</a></li>
						<li><a href="http://groups.google.com/group/cufon" class="external">Community</a></li>
						<li><a href="http://github.com/sorccu/cufon/tree/master">Source</a></li>
						<li><form style="display:inline" action="https://www.paypal.com/cgi-bin/webscr" method="post">
						<input type="hidden" name="cmd" value="_s-xclick">
						<input type="hidden" name="hosted_button_id" value="KKEVALQHJYV74">
						<input type="image" style="vertical-align:middle" src="https://www.paypalobjects.com/WEBSCR-640-20110429-1/en_US/i/btn/btn_donate_LG.gif" border="0" name="submit" title="Keep us going!" alt="PayPal - The safer, easier way to pay online!">
						<img alt="" border="0" src="https://www.paypalobjects.com/WEBSCR-640-20110429-1/en_US/i/scr/pixel.gif" width="1" height="1">
						</form></li>
					</ul>

				</div>

				<div id="content">

					<form id="generator" action="convert.php" method="post" enctype="multipart/form-data">

						<div class="section">
						
							<h3>Important information for Cufón users</h3
							
							<p><ins><strong>UPDATE Oct 24:</strong> We have released version 1.09i, which is the same as 1.09
							but IE9-compatible. 1.10 is on its way as well. Keep in mind that you do not need to convert your font
							files again, just replace your old <code>cufon-yui.js</code> with a new one and you're good to go.</ins></p>
							
							<p><small>As it currently stands, version 1.09 does not work in IE9 beta which was just released.
							Just in case it doesn't work in the final version either, we've implemented a fix in the
							latest development version. <strong>There will be a new release some time in the near future</strong>.
							Meanwhile, there are also a few ways to fix your site without having
							to update your <code>cufon-yui.js</code>. <a href="http://github.com/sorccu/cufon/wiki/faq#faq-8" class="external">See here for details</a>.</small></p>

							<p><strong>You might also want to take this opportunity</strong> to <a href="http://typekit.com/ref/cufon" onclick="if (window.pageTracker) pageTracker._trackEvent('Try Typekit', 'Try', 'IE9 beta Upgrade Notice')" class="external">try Typekit</a>, a hosted,
							<code>@font-face</code>-based alternative. Yes, that means they support text
							selection. It's the easiest way to embrace standards.</p>

						</div>

						<div class="section">

							<h3>Select the font you'd like to use</h3>

							<dl>
								<dt><label for="ifont_0" id="lfont_0">Regular typeface</label></dt>
								<dd><input type="file" name="font[]" id="ifont_0" size="40" /></dd>
								<dt><label for="ifont_1" id="lfont_1">Bold typeface (optional)</label></dt>
								<dd><input type="file" name="font[]" id="ifont_1" size="40" /></dd>
								<dt><label for="ifont_2" id="lfont_2">Italic typeface (optional)</label></dt>
								<dd><input type="file" name="font[]" id="ifont_2" size="40" /></dd>
								<dt><label for="ifont_3" id="lfont_3">Bold Italic typeface (optional)</label></dt>
								<dd><input type="file" name="font[]" id="ifont_3" size="40" /></dd>
							</dl>

							<p class="info">On Windows, <em>you may first have to copy the font file out of the Fonts folder and paste it elsewhere</em> in order to be able to select it.</p>

							<p class="info">Currently only TrueType (TTF), OpenType (OTF), Printer Font Binary (PFB) and PostScript fonts are supported. Files are disposed of immediately after conversion.</p>

							<dl>
								<dt><label for="ifamily">Use the following value as the <code>font-family</code> of the generated font (optional)</label></dt>
								<dd><input type="text" name="family" id="ifamily" size="70" maxlength="150" />
									<p class="info">Useful if you're using multiple variants of the same font (bold, italic etc). Sometimes they may have slightly different family names, which may lead to unexpected behavior.</p>
								</dd>
							</dl>

							<dl>
								<dt><label for="ipermission" class="important"><input type="checkbox" name="permission" id="ipermission" value="yes" /> The EULAs of these fonts allow Web Embedding (without <a href="http://www.adobe.com/products/flashplayer/" class="external">Adobe Flash</a>)</label></dt>
								<dd>
									<p class="info">See <a href="http://www.fontembedding.com/fonts-and-the-law/" class="external">Fonts and the Law</a> at <a href="http://www.fontembedding.com" class="external">fontembedding.com</a> for more information.
									Fonts produced by the following foundries/vendors/creators are <em>known to be safe</em>:
									<a href="http://www.adobe.com/type/embedding.html" class="external">Adobe Systems</a>.
									The following are <em>known to require separate or extended licenses</em> for Web Embedding:
									<a href="http://www.bertholdtypes.com/info/agreement.html" class="external">Berthold</a> (separate),
									<a href="http://www.fontfont.com/support/licensing.ep" class="external">FontFont</a> (separate),
									<a href="http://www.fontsmith.com/support/licencingandusage/end-user-licence-agreement-eula.cfm" class="external">Fontsmith</a> (separate),
									<a href="http://www.typography.com/" class="external">Hoefler &amp; Frere-Jones</a> (separate),
									<a href="http://www.itcfonts.com/About/Embedding.htm" class="external">ITC</a> (separate),
									<a href="http://www.linotype.com/2061-28225/licenseagreementforfontsoftware.html" class="external">Linotype</a> (extended).</p>
								</dd>
							</dl>

						</div>

						<div class="section">

							<h3>Include the following glyphs (if available)</h3>

							<dl>
								<dt><label for="iglyphs_all"><input type="checkbox" name="glyphs[]" id="iglyphs_all" value="0x0-0xFFFF" /> All</label></dt>
								<dd>Includes all available glyphs. Highly unrecommended.</dd>
								<dt><label for="iglyphs_uc"><input type="checkbox" name="glyphs[]" id="iglyphs_uc" value="0x41-0x5A" /> Uppercase</label></dt>
								<dd>Basic Latin uppercase letters (A-Z). (26 glyphs)</dd>
								<dt><label for="iglyphs_lc"><input type="checkbox" name="glyphs[]" id="iglyphs_lc" value="0x61-0x7A" /> Lowercase</label></dt>
								<dd>Basic Latin lowercase letters (a-z). (26 glyphs)</dd>
								<dt><label for="iglyphs_n"><input type="checkbox" name="glyphs[]" id="iglyphs_n" value="0x30-0x39" /> Numerals</label></dt>
								<dd>Basic Latin digits (0-9). (10 glyphs)</dd>
								<dt><label for="iglyphs_p"><input type="checkbox" name="glyphs[]" id="iglyphs_p" value="0x20-0x2F,0x3A-0x40,0x5B-0x60,0x7B-0x7E" /> Punctuation</label></dt>
								<dd>Basic Latin punctuation (!@#%...). (33 glyphs)</dd>
								<dt><label for="iglyphs_wp"><input type="checkbox" name="glyphs[]" id="iglyphs_wp" value="0xD7,0x2013,0x2014,0x2018,0x2019,0x2026,0x2032,0x2033,0x201C,0x201D,0x2122" /> WordPress punctuation</label></dt>
								<dd><a href="http://codex.wordpress.org/User:Here/Texturize" class="external">Texturized</a> WordPress punctuation. Some fonts may not support all of these characters. (12 glyphs)</dd>
								<dt><label for="iglyphs_bl"><input type="checkbox" name="glyphs[]" id="iglyphs_bl" value="0x20-0x7E" checked="checked" /> Basic Latin</label></dt>
								<dd>Basic Latin glyphs within the Unicode range 0x0020 to 0x007E. (95 glyphs)</dd>
								<dt><label for="iglyphs_l1s"><input type="checkbox" name="glyphs[]" id="iglyphs_l1s" value="0xA0-0xFF" /> Latin-1 Supplement</label></dt>
								<dd>Latin glyphs within the Unicode range 0x00A0 to 0x00FF. Includes punctuation, currency symbols, numerals and common accented characters. (96 glyphs)</dd>
								<dt><label for="iglyphs_l1ea"><input type="checkbox" name="glyphs[]" id="iglyphs_l1ea" value="0x100-0x17F" /> Latin Extended-A</label></dt>
								<dd>Extended Latin glyphs within the Unicode range 0x0100 to 0x017F. (128 glyphs)</dd>
								<dt><label for="iglyphs_l1eb"><input type="checkbox" name="glyphs[]" id="iglyphs_l1eb" value="0x180-0x24F" /> Latin Extended-B</label></dt>
								<dd>Extended Latin glyphs within the Unicode range 0x0180 to 0x024F. (208 glyphs)</dd>
								<dt><label for="iglyphs_cyr"><input type="checkbox" name="glyphs[]" id="iglyphs_cyr" value="0x400-0x4FF,0x500-0x52F,0x2DE0-0x2DFF,0xA640-0xA69F" /> Cyrillic Alphabet</label></dt>
								<dd>For a complete list, see <a href="http://en.wikipedia.org/wiki/Cyrillic_characters_in_Unicode" class="external">Cyrillic characters in Unicode</a>. (up to 432 glyphs)</dd>
								<dt><label for="iglyphs_rus"><input type="checkbox" name="glyphs[]" id="iglyphs_rus" value="0x410-0x44F,0x401,0x451" /> Russian Alphabet</label></dt>
								<dd>A refined selection of Cyrillic characters commonly used in the Russian language. (66 glyphs)</dd>
								<dt><label for="iglyphs_greek"><input type="checkbox" name="glyphs[]" id="iglyphs_greek" value="0x370-0x3FF" /> Greek and Coptic</label></dt>
								<dd>The whole Greek and Coptic Unicode block. For more information, see <a href="http://en.wikipedia.org/wiki/Greek_alphabet#Greek_in_Unicode" class="external">Greek in Unicode</a>. (up to 144 glyphs)</dd>
								<dt><label for="icustomGlyphs"> .. and also these single characters</label></dt>
								<dd><input type="text" name="customGlyphs" id="icustomGlyphs" size="70" maxlength="250" /></dd>
							</dl>

						</div>

						<div class="section">

							<h3>Security</h3>

							<dl>
								<dt><label for="idomains">Limit usage to the following domain(s)</label></dt>
								<dd>
									<input type="text" name="domains" id="idomains" size="70" maxlength="250" value="" /> <span class="example">(example.org, www.example.org)</span>
									<p class="info"><strong><em>Utilizing this feature is highly recommended, and may even be required if you're using commercial fonts.</em></strong></p>
									<p class="info">Separate multiple domains by either commas or spaces. You can also use wildcards (e.g. *.example.org to cover all subdomains of example.org). Using a font that doesn't match any of the allowed domains results in no text showing up.</p>
								</dd>
							</dl>

						</div>

						<div class="section">

							<h3>Performance &amp; file size</h3>

							<dl>
								<dt><label for="iemSize">Scale the font to the following size</label></dt>
								<dd>
									<label for="iemSize"><input type="text" name="emSize" id="iemSize" value="360" maxlength="4" size="4" /> units per em</label>
									<label for="idisableScaling"><input type="checkbox" name="disableScaling" id="idisableScaling" value="yes" /> No thanks, use the font's own value</label>
									<p class="info">A lower value (64 at minimum) results in slightly better performance and smaller file size at the cost of accuracy. Values lower than 256 are not recommended unless you are OK with visible loss of detail. You may also use the <a href="../doc/optimal-scaling.html">optimal scaling chart</a> to find a suitable scaling value. Native values in quality fonts are usually either 1000 or 2048.</p>
								</dd>
								<dt><label for="isimplifyDelta">If allowed, optimized paths may differ from the original by at most</label></dt>
								<dd>
									<label for="isimplifyDelta"><input type="text" name="simplifyDelta" id="isimplifyDelta" value="2" maxlength="4" size="4" /> units</label>
									<label for="isimplify"><input type="checkbox" name="simplify" id="isimplify" value="yes" checked="checked" /> Allow path optimization</label>
									<p class="info"><strong><em>It's recommended to disable this feature if you're planning to use small font sizes.</em></strong></p>
									<p class="info">You should keep this value fairly low, at about 0.5-1% of the font's em-size. Optimizations are performed <em>after</em> the font has been scaled (if at all).</p>
								</dd>
								<dt><label for="ikerning"><input type="checkbox" name="kerning" id="ikerning" value="yes" checked="checked" /> Include kerning tables (improves readability but slightly increases file size)</label></dt>
							</dl>

							<p>Also, try to make sure your server serves gzipped JavaScript. 70-80% drops in file size are not unheard of.</p>

						</div>

						<div id="customization" class="section">

							<h3>Customization (for 3rd-party scripts only)</h3>

							<dl>
								<dt><label for="icallback">The following JavaScript function will receive the font data</label></dt>
								<dd><input type="text" name="callback" id="icallback" value="Cufon.registerFont" size="70" maxlength="250" />
									<a href="#set-callback" class="callback" title="Cufon.registerFont"><img src="img/cufon16.png" alt="Cufón" title="Cufón" width="16" height="16" /></a>
									<a href="#set-callback" class="callback" title="Raphael.registerFont"><img src="img/raphael16.png" alt="Raphaël" title="Raphaël" width="16" height="16" /></a>
								</dd>
							</dl>

						</div>

						<div class="section">

							<h3>Terms</h3>

							<p>Cufón is distributed under the <a href="http://en.wikipedia.org/wiki/MIT_License" class="external">MIT license</a>. By using this tool you agree to its terms.</p>

							<p>Should you require help you may ask for it at <a href="http://groups.google.com/group/cufon" class="external">our Google Group</a>, but keep
							in mind that you are in no way entitled to support, which means that even if you do not
							get a satisfactory answer you may not complain about it. Nice people are more likely to
							get helpful answers.</p>

							<p><label for="iterms" class="important"><input type="checkbox" name="terms" id="iterms" value="yes" /> I acknowledge and accept these terms</label></p>

						</div>

						<div class="actions">

							<button type="submit">Let's do this!</button>

						</div>

					</form>

				</div>

				<div id="foot">

					<p>Idea and implementation by Simo Kinnunen (<a href="http://twitter.com/sorccu"><img src="img/twitter.png" alt="twitter" /></a>), 2008-. Bugs by nature.</p>

				</div>

			</div>

		</div>

		<script type="text/javascript"> Cufon.now(); </script>

		<script type="text/javascript">
		var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
		document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
		</script>
		<script type="text/javascript">
		try {
		var pageTracker = _gat._getTracker("UA-8372480-1");
		pageTracker._trackPageview();
		} catch(err) {}</script>

	</body>

</html>
