// Decompiled with JetBrains decompiler
// Type: Confins.Report.AssetDocument.AssetDocumentTableAdapters.spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocTableAdapter
// Assembly: Confins.Report.AssetDocument, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B3BAE3E-7BF5-41ED-89F8-6CD9470EDA45
// Assembly location: C:\Users\Darma\Downloads\Centro Phase 2 WISE\Object Deployment\BATCH-WOMF-299 Part 2\REPORT\bin\CustomRptDataProvider\Confins.Report.AssetDocument.dll

using Confins.Report.AssetDocument.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Confins.Report.AssetDocument.AssetDocumentTableAdapters
{
  [DesignerCategory("code")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  [ToolboxItem(true)]
  [DataObject(true)]
  public class spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocTableAdapter() => this.ClearBeforeFill = true;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected internal SqlDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal SqlConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
        }
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal SqlTransaction Transaction
    {
      get => this._transaction;
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected SqlCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public bool ClearBeforeFill
    {
      get => this._clearBeforeFill;
      set => this._clearBeforeFill = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitAdapter()
    {
      this._adapter = new SqlDataAdapter();
      this._adapter.TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "spDOC_FormOrderPengeluaranAgrmntMultiReleaseDoc",
        ColumnMappings = {
          {
            "RELEASE_TRX_DOC_NO",
            "RELEASE_TRX_DOC_NO"
          },
          {
            "AGRMNT_NO",
            "AGRMNT_NO"
          },
          {
            "CUST_NAME",
            "CUST_NAME"
          },
          {
            "DOC_NO",
            "DOC_NO"
          },
          {
            "AGRMNT_DOC_NAME",
            "AGRMNT_DOC_NAME"
          },
          {
            "NOTES",
            "NOTES"
          },
          {
            "REQ_BY",
            "REQ_BY"
          },
          {
            "DistujuiOleh",
            "DistujuiOleh"
          },
          {
            "Tanggal",
            "Tanggal"
          },
          {
            "Bulan",
            "Bulan"
          },
          {
            "Tahun",
            "Tahun"
          }
        }
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = Settings.Default.AssetDocumentEntitiesSQLConn;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "dbo.spDOC_FormOrderPengeluaranAgrmntMultiReleaseDoc";
      this._commandCollection[0].CommandType = CommandType.StoredProcedure;
      this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[0].Parameters.Add(new SqlParameter("@ReleaseTrxId", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    public virtual int Fill(
      Confins.Report.AssetDocument.AssetDocument.spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocDataTable dataTable,
      long? ReleaseTrxId)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (ReleaseTrxId.HasValue)
        this.Adapter.SelectCommand.Parameters[1].Value = (object) ReleaseTrxId.Value;
      else
        this.Adapter.SelectCommand.Parameters[1].Value = (object) DBNull.Value;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual Confins.Report.AssetDocument.AssetDocument.spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocDataTable GetData(
      long? ReleaseTrxId)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (ReleaseTrxId.HasValue)
        this.Adapter.SelectCommand.Parameters[1].Value = (object) ReleaseTrxId.Value;
      else
        this.Adapter.SelectCommand.Parameters[1].Value = (object) DBNull.Value;
      Confins.Report.AssetDocument.AssetDocument.spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocDataTable releaseDocDataTable = new Confins.Report.AssetDocument.AssetDocument.spDOC_FormOrderPengeluaranAgrmntMultiReleaseDocDataTable();
      this.Adapter.Fill((DataTable) releaseDocDataTable);
      return releaseDocDataTable;
    }
  }
}
