<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>How to delete files to the Recycle Bin folder</title>
</head>
<body>
	<script type="text/javascript">
		function onDeleting(s, e) {
			e.cancel = true;
			if (e.isFolder)
				panel.PerformCallback("folder|" + e.fullName + "|" + e.name);
			else
				panel.PerformCallback("file|" + e.fullName + "|" + e.name);
		}
	</script>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" Width="1340px" ClientInstanceName="panel" OnCallback="ASPxCallbackPanel1_Callback" Height="547px">
				<PanelCollection>
					<dx:PanelContent>
						<dx:ASPxFileManager ID="ASPxFileManager1" runat="server" SettingsEditing-AllowDelete="true">
							<Settings RootFolder="~\Folder1" />
							<ClientSideEvents ItemDeleting="onDeleting" />
						</dx:ASPxFileManager>
					</dx:PanelContent>
				</PanelCollection>
			</dx:ASPxCallbackPanel>

		</div>
	</form>
</body>
</html>