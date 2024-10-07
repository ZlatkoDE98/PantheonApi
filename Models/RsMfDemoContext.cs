using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PantheonApi.Models;

public partial class RsMfDemoContext : DbContext
{
    public RsMfDemoContext()
    {
    }

    public RsMfDemoContext(DbContextOptions<RsMfDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<THeMove> THeMoves { get; set; }

    public virtual DbSet<THeMoveItem> THeMoveItems { get; set; }

    public virtual DbSet<THeOrder> THeOrders { get; set; }

    public virtual DbSet<THeOrderItem> THeOrderItems { get; set; }

    public virtual DbSet<THeSetItem> THeSetItems { get; set; }

    public virtual DbSet<THeSetSubj> THeSetSubjs { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DEV-T470S\\SQLEXPRESS;Database=RS_MF_DEMO;User Id=sa;Password=DataLab123DataLab;TrustServerCertificate=true;");
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<THeMove>(entity =>
        {
            entity.HasKey(e => e.AnQid).HasName("IX_tHE_Move_Id");

            entity.ToTable("tHE_Move", tb =>
                {
                    tb.HasTrigger("gHE_MoveInsUD");
                    tb.HasTrigger("gHE_MoveStatus_IU");
                    tb.HasTrigger("gHE_MoveUpdUD");
                    tb.HasTrigger("gHE_TrackMovePrimaryKeyChanges");
                    tb.HasTrigger("gHE_TrackMovePrimaryKeyDeletes");
                    tb.HasTrigger("gHE_tHE_Move_Update_acKey_QId");
                    tb.HasTrigger("gPA_OnDelete_tHE_Move");
                    tb.HasTrigger("gPA_tHE_Move_UC");
                    tb.HasTrigger("pPA_Undo_tHE_Move_Delete");
                    tb.HasTrigger("pPA_Undo_tHE_Move_Update");
                });

            entity.HasIndex(e => e.AcParityType, "IX_Move_tHE_SetDelTermType_57");

            entity.HasIndex(e => e.AcLoyaltyCard, "IX_Move_tPA_LoyaltyCard_3058");

            entity.HasIndex(e => new { e.AcReceiver, e.AcReceiverStock, e.AdDate }, "IX_tHE_Move_Receiver");

            entity.HasIndex(e => new { e.AcReceiver, e.AcKey }, "IX_tHE_Move_Receiver_Key");

            entity.HasIndex(e => new { e.AcVerifyStatus, e.AcDocType, e.AcIssuer, e.AdTimeIns }, "IX_tHE_Move_VerifyStatus_DocType_Issuer_TimeIns");

            entity.HasIndex(e => e.AcInsertedFrom, "IX_tHE_Move_acInsertedFrom");

            entity.HasIndex(e => new { e.AcIssuerStock, e.AdDate }, "IX_tHE_Move_acIssuerStock");

            entity.HasIndex(e => e.AdDate, "IX_tHE_Move_acIssuerStock_filtered").HasFilter("([acIssuerStock]='Y')");

            entity.HasIndex(e => new { e.AcReceiverStock, e.AdDate }, "IX_tHE_Move_acReceiverStock");

            entity.HasIndex(e => e.AdDate, "IX_tHE_Move_acReceiverStock_filtered").HasFilter("([acReceiverStock]='Y')");

            entity.HasIndex(e => e.AcVerifiedPrices, "IX_tHE_Move_acVerifiedPrices");

            entity.HasIndex(e => new { e.AcDocType, e.AcVerifiedPrices, e.AnForPay }, "iHE_Move_46");

            entity.HasIndex(e => new { e.AcVerifiedPrices, e.AnForPay }, "iHE_Move_47");

            entity.HasIndex(e => new { e.AcVerifyStatus, e.AdDateInv, e.AdTimeChg }, "iHE_Move_48");

            entity.HasIndex(e => new { e.AcRefNo4, e.AcDocType, e.AdDate }, "iHE_Move_49");

            entity.HasIndex(e => new { e.AcDocType, e.AnNoteClerk, e.AdDateTimePrint }, "iHE_Move_50");

            entity.HasIndex(e => e.AcContractNo, "iHE_Move_ContractNo");

            entity.HasIndex(e => e.AdDate, "iHE_Move_Date");

            entity.HasIndex(e => new { e.AdDateInv, e.AcDocType, e.AnUserIns }, "iHE_Move_DateInv");

            entity.HasIndex(e => e.AdDateVat, "iHE_Move_DateVAT");

            entity.HasIndex(e => e.AcDept, "iHE_Move_Dept");

            entity.HasIndex(e => e.AcDeptOut, "iHE_Move_DeptOut");

            entity.HasIndex(e => e.AcDoc1, "iHE_Move_Doc1");

            entity.HasIndex(e => e.AcDoc2, "iHE_Move_Doc2");

            entity.HasIndex(e => new { e.AcDocType, e.AcPosted }, "iHE_Move_DocTypeKey");

            entity.HasIndex(e => new { e.AcIssuer, e.AdDate, e.AdDateInv, e.AcDocType, e.AcIssuerStock }, "iHE_Move_Issuer");

            entity.HasIndex(e => e.AcPrsn3, "iHE_Move_Prsn3");

            entity.HasIndex(e => new { e.AcReceiver, e.AdDate, e.AcDocType }, "iHE_Move_Receiver");

            entity.HasIndex(e => e.AcStatement, "idx_tHE_Move_14").HasFillFactor(75);

            entity.HasIndex(e => e.AcPayMethod, "idx_tHE_Move_15");

            entity.HasIndex(e => e.AcDelivery, "idx_tHE_Move_16");

            entity.HasIndex(e => e.AnClerk, "idx_tHE_Move_18");

            entity.HasIndex(e => e.AcCurrency, "idx_tHE_Move_19");

            entity.HasIndex(e => e.AcParity, "idx_tHE_Move_20");

            entity.HasIndex(e => e.AcParityPost, "idx_tHE_Move_21");

            entity.HasIndex(e => e.AnNoteClerk, "idx_tHE_Move_25");

            entity.HasIndex(e => e.AnSigner1, "idx_tHE_Move_28");

            entity.HasIndex(e => e.AnSigner2, "idx_tHE_Move_29");

            entity.HasIndex(e => e.AnSigner3, "idx_tHE_Move_30");

            entity.HasIndex(e => e.AnSeqWhNoIn, "idx_tHE_Move_31").HasFillFactor(75);

            entity.HasIndex(e => e.AnSeqWhNoOut, "idx_tHE_Move_32").HasFillFactor(75);

            entity.HasIndex(e => e.AcAcctClaimLiab, "ix_FK_acAcctClaimLiab");

            entity.HasIndex(e => e.AcCostDrvOut, "ix_FK_acCostDrvOut");

            entity.HasIndex(e => e.AcDocTypePayOrd, "ix_FK_acDocTypePayOrd");

            entity.HasIndex(e => e.AcDocTypePayOrdFgn, "ix_FK_acDocTypePayOrdFgn");

            entity.HasIndex(e => e.AcIsocountry, "ix_FK_acISOCountry");

            entity.HasIndex(e => e.AcLimitDuty, "ix_FK_acLimitDuty");

            entity.HasIndex(e => e.AcKey, "kHE_Move_0").IsUnique();

            entity.Property(e => e.AnQid).HasColumnName("anQId");
            entity.Property(e => e.AcAcctClaimLiab)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctClaimLiab");
            entity.Property(e => e.AcAddress)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAddress");
            entity.Property(e => e.AcBuyerCostCenterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acBuyerCostCenterId");
            entity.Property(e => e.AcBuyerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("acBuyerId");
            entity.Property(e => e.AcCode1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acCode1");
            entity.Property(e => e.AcCode2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acCode2");
            entity.Property(e => e.AcCode3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acCode3");
            entity.Property(e => e.AcContactPrsn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acContactPrsn");
            entity.Property(e => e.AcContactPrsn3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acContactPrsn3");
            entity.Property(e => e.AcContractNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acContractNo");
            entity.Property(e => e.AcCorrType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCorrType");
            entity.Property(e => e.AcCostDrvOut)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCostDrvOut");
            entity.Property(e => e.AcCostDutyCalcType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("D")
                .IsFixedLength()
                .HasColumnName("acCostDutyCalcType");
            entity.Property(e => e.AcCreatFromWo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acCreatFromWO");
            entity.Property(e => e.AcCreatePayOrd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acCreatePayOrd");
            entity.Property(e => e.AcCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCurrency");
            entity.Property(e => e.AcDelivery)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDelivery");
            entity.Property(e => e.AcDeliveryUnderArt163a)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("acDeliveryUnderART163A");
            entity.Property(e => e.AcDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDept");
            entity.Property(e => e.AcDeptOut)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDeptOut");
            entity.Property(e => e.AcDoc1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDoc1");
            entity.Property(e => e.AcDoc2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDoc2");
            entity.Property(e => e.AcDocType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocType");
            entity.Property(e => e.AcDocTypePayOrd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocTypePayOrd");
            entity.Property(e => e.AcDocTypePayOrdFgn)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocTypePayOrdFgn");
            entity.Property(e => e.AcDutyPaidByOurComp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acDutyPaidByOurComp");
            entity.Property(e => e.AcDutyTran)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acDutyTran");
            entity.Property(e => e.AcExcisePaidByOurComp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acExcisePaidByOurComp");
            entity.Property(e => e.AcFieldSa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSA");
            entity.Property(e => e.AcFieldSb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSB");
            entity.Property(e => e.AcFieldSc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSC");
            entity.Property(e => e.AcFieldSd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSD");
            entity.Property(e => e.AcFieldSe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSE");
            entity.Property(e => e.AcFieldSf)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSF");
            entity.Property(e => e.AcFieldSg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSG");
            entity.Property(e => e.AcFieldSh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSH");
            entity.Property(e => e.AcFieldSi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSI");
            entity.Property(e => e.AcFieldSj)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSJ");
            entity.Property(e => e.AcFiscExclude)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acFiscExclude");
            entity.Property(e => e.AcFiscPayMethodOld)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acFiscPayMethodOld");
            entity.Property(e => e.AcFiscPaymentChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acFiscPaymentChange");
            entity.Property(e => e.AcFiscSalesBookDocNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFiscSalesBookDocNo");
            entity.Property(e => e.AcFiscSalesBookSerNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFiscSalesBookSerNo");
            entity.Property(e => e.AcFiscSalesBookSetNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFiscSalesBookSetNo");
            entity.Property(e => e.AcFiscStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("acFiscStatus");
            entity.Property(e => e.AcFiskPrintNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFiskPrintNo");
            entity.Property(e => e.AcFiskPrintNoS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFiskPrintNoS");
            entity.Property(e => e.AcForm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acForm");
            entity.Property(e => e.AcIdbcstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acIDBCState");
            entity.Property(e => e.AcInsFromImport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acInsFromImport");
            entity.Property(e => e.AcInsertedFrom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength()
                .HasColumnName("acInsertedFrom");
            entity.Property(e => e.AcInternalNote)
                .HasMaxLength(2000)
                .HasDefaultValue("")
                .HasColumnName("acInternalNote");
            entity.Property(e => e.AcInvoiceForm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acInvoiceForm");
            entity.Property(e => e.AcIsocountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acISOCountry");
            entity.Property(e => e.AcIssuer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acIssuer");
            entity.Property(e => e.AcIssuerStock)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("acIssuerStock");
            entity.Property(e => e.AcKey)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acKey");
            entity.Property(e => e.AcKeyView)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasComputedColumnSql("((((left([acKey],(2))+'-')+substring([acKey],(3),(4)))+'-')+right([acKey],(6)))", true)
                .HasColumnName("acKeyView");
            entity.Property(e => e.AcLimitDuty)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acLimitDuty");
            entity.Property(e => e.AcLoyaltyCard)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acLoyaltyCard");
            entity.Property(e => e.AcMoveTranType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acMoveTranType");
            entity.Property(e => e.AcNote)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNote");
            entity.Property(e => e.AcNote2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNote2");
            entity.Property(e => e.AcNote3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNote3");
            entity.Property(e => e.AcPackNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPackNum");
            entity.Property(e => e.AcParity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acParity");
            entity.Property(e => e.AcParityPost)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acParityPost");
            entity.Property(e => e.AcParityType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acParityType");
            entity.Property(e => e.AcPayMethod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayMethod");
            entity.Property(e => e.AcPayMethodOld)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayMethodOld");
            entity.Property(e => e.AcPayPurpose1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayPurpose1");
            entity.Property(e => e.AcPayPurpose2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayPurpose2");
            entity.Property(e => e.AcPayPurpose3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayPurpose3");
            entity.Property(e => e.AcPost)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPost");
            entity.Property(e => e.AcPosted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acPosted");
            entity.Property(e => e.AcPriceRate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .IsFixedLength()
                .HasColumnName("acPriceRate");
            entity.Property(e => e.AcProc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acProc");
            entity.Property(e => e.AcProtocol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acProtocol");
            entity.Property(e => e.AcPrsn3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPrsn3");
            entity.Property(e => e.AcReceiver)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acReceiver");
            entity.Property(e => e.AcReceiverStock)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("acReceiverStock");
            entity.Property(e => e.AcRefNo1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo1");
            entity.Property(e => e.AcRefNo2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo2");
            entity.Property(e => e.AcRefNo3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo3");
            entity.Property(e => e.AcRefNo4)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo4");
            entity.Property(e => e.AcRetailSale)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acRetailSale");
            entity.Property(e => e.AcRoundVatonDoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acRoundVATOnDoc");
            entity.Property(e => e.AcSetOfDeal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSetOfDeal");
            entity.Property(e => e.AcSpecPayment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acSpecPayment");
            entity.Property(e => e.AcStatement)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acStatement");
            entity.Property(e => e.AcStockStartInventory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acStockStartInventory");
            entity.Property(e => e.AcStornoType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acStornoType");
            entity.Property(e => e.AcTaxIdentificationCardNum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acTaxIdentificationCardNum");
            entity.Property(e => e.AcTrailerRegistrationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("acTrailerRegistrationNumber");
            entity.Property(e => e.AcTransPaperForm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acTransPaperForm");
            entity.Property(e => e.AcTransportCalcType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("V")
                .HasColumnName("acTransportCalcType");
            entity.Property(e => e.AcTransporter)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("acTransporter");
            entity.Property(e => e.AcTriangTrans)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("acTriangTrans");
            entity.Property(e => e.AcUjpdocId)
                .HasMaxLength(140)
                .IsUnicode(false)
                .HasColumnName("acUJPDocId");
            entity.Property(e => e.AcUpncode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUPNCode");
            entity.Property(e => e.AcUpncontrolNum)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUPNControlNum");
            entity.Property(e => e.AcUpnprint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .HasColumnName("acUPNPrint");
            entity.Property(e => e.AcUpnreference)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("SI")
                .HasColumnName("acUPNReference");
            entity.Property(e => e.AcUseFiscalRounding)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acUseFiscalRounding");
            entity.Property(e => e.AcVatattType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("00")
                .IsFixedLength()
                .HasColumnName("acVATAttType");
            entity.Property(e => e.AcVatchecked)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acVATChecked");
            entity.Property(e => e.AcVatexclude)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acVATExclude");
            entity.Property(e => e.AcVatpaidByOurComp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acVATPaidByOurComp");
            entity.Property(e => e.AcVehicleRegistrationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("acVehicleRegistrationNumber");
            entity.Property(e => e.AcVerifiedPrices)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acVerifiedPrices");
            entity.Property(e => e.AcVerifyStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("acVerifyStatus");
            entity.Property(e => e.AcWayOfSale)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("K")
                .IsFixedLength()
                .HasColumnName("acWayOfSale");
            entity.Property(e => e.AdAdvancePayment)
                .HasColumnType("datetime")
                .HasColumnName("adAdvancePayment");
            entity.Property(e => e.AdDate)
                .HasDefaultValueSql("(dateadd(day,datediff(day,(0),getdate()),(0)))")
                .HasColumnType("smalldatetime")
                .HasColumnName("adDate");
            entity.Property(e => e.AdDateBeforeVat)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateBeforeVAT");
            entity.Property(e => e.AdDateDdvpay)
                .HasColumnType("datetime")
                .HasColumnName("adDateDDVPay");
            entity.Property(e => e.AdDateDoc1)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateDoc1");
            entity.Property(e => e.AdDateDoc2)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateDoc2");
            entity.Property(e => e.AdDateDue)
                .HasDefaultValueSql("(dateadd(day,datediff(day,(0),getdate()),(0)))")
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateDue");
            entity.Property(e => e.AdDateInv)
                .HasDefaultValueSql("(dateadd(day,datediff(day,(0),getdate()),(0)))")
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateInv");
            entity.Property(e => e.AdDateTimePrint)
                .HasColumnType("datetime")
                .HasColumnName("adDateTimePrint");
            entity.Property(e => e.AdDateVat)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateVAT");
            entity.Property(e => e.AdFieldDa)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDA");
            entity.Property(e => e.AdFieldDb)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDB");
            entity.Property(e => e.AdFieldDc)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDC");
            entity.Property(e => e.AdFieldDd)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDD");
            entity.Property(e => e.AdSigned1)
                .HasColumnType("datetime")
                .HasColumnName("adSigned1");
            entity.Property(e => e.AdSigned2)
                .HasColumnType("datetime")
                .HasColumnName("adSigned2");
            entity.Property(e => e.AdSigned3)
                .HasColumnType("datetime")
                .HasColumnName("adSigned3");
            entity.Property(e => e.AdTimeChg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeChg");
            entity.Property(e => e.AdTimeFiscal)
                .HasColumnType("datetime")
                .HasColumnName("adTimeFiscal");
            entity.Property(e => e.AdTimeIns)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeIns");
            entity.Property(e => e.AdTransportDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("adTransportDate");
            entity.Property(e => e.AdVatattDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("adVATAttDate");
            entity.Property(e => e.AnBnkAcctNo)
                .HasDefaultValue(1)
                .HasColumnName("anBnkAcctNo");
            entity.Property(e => e.AnBuyerCostCenterIdDef)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("anBuyerCostCenterIdDef");
            entity.Property(e => e.AnBuyerIdDef)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("anBuyerIdDef");
            entity.Property(e => e.AnClerk).HasColumnName("anClerk");
            entity.Property(e => e.AnCurrValue)
                .HasColumnType("money")
                .HasColumnName("anCurrValue");
            entity.Property(e => e.AnDaysForPayment).HasColumnName("anDaysForPayment");
            entity.Property(e => e.AnDirectCost).HasColumnName("anDirectCost");
            entity.Property(e => e.AnDiscount)
                .HasColumnType("money")
                .HasColumnName("anDiscount");
            entity.Property(e => e.AnDuty)
                .HasColumnType("money")
                .HasColumnName("anDuty");
            entity.Property(e => e.AnFgnBankNo)
                .HasDefaultValue(0)
                .HasColumnName("anFgnBankNo");
            entity.Property(e => e.AnFieldNa)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNA");
            entity.Property(e => e.AnFieldNb)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNB");
            entity.Property(e => e.AnFieldNc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNC");
            entity.Property(e => e.AnFieldNd)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldND");
            entity.Property(e => e.AnFieldNe)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNE");
            entity.Property(e => e.AnFieldNf)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNF");
            entity.Property(e => e.AnFieldNg)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNG");
            entity.Property(e => e.AnFieldNh)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNH");
            entity.Property(e => e.AnFieldNi)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNI");
            entity.Property(e => e.AnFieldNj)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNJ");
            entity.Property(e => e.AnForPay)
                .HasColumnType("money")
                .HasColumnName("anForPay");
            entity.Property(e => e.AnFxrate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFXRate");
            entity.Property(e => e.AnIncTax)
                .HasColumnType("money")
                .HasColumnName("anIncTax");
            entity.Property(e => e.AnLicensesBase)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anLicensesBase");
            entity.Property(e => e.AnLicensesVat)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anLicensesVAT");
            entity.Property(e => e.AnNoteClerk).HasColumnName("anNoteClerk");
            entity.Property(e => e.AnOurBankAcctNo)
                .HasDefaultValue(0)
                .HasColumnName("anOurBankAcctNo");
            entity.Property(e => e.AnOurBankAcctNoFgn)
                .HasDefaultValue(0)
                .HasColumnName("anOurBankAcctNoFgn");
            entity.Property(e => e.AnPaid2)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPaid2");
            entity.Property(e => e.AnPaidAcct)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPaidAcct");
            entity.Property(e => e.AnPaidCashReg)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPaidCashReg");
            entity.Property(e => e.AnPaidPrepayment)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPaidPrepayment");
            entity.Property(e => e.AnRebate)
                .HasColumnType("money")
                .HasColumnName("anRebate");
            entity.Property(e => e.AnRefund)
                .HasColumnType("money")
                .HasColumnName("anRefund");
            entity.Property(e => e.AnRefundCurr)
                .HasColumnType("money")
                .HasColumnName("anRefundCurr");
            entity.Property(e => e.AnReverseChargeCoefficient)
                .HasDefaultValue(100.0)
                .HasColumnName("anReverseChargeCoefficient");
            entity.Property(e => e.AnRoomTableId).HasColumnName("anRoomTableID");
            entity.Property(e => e.AnRoundItem)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundItem");
            entity.Property(e => e.AnRoundItemFc)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundItemFC");
            entity.Property(e => e.AnRoundPrice)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundPrice");
            entity.Property(e => e.AnRoundValue)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundValue");
            entity.Property(e => e.AnRoundValueOc)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundValueOC");
            entity.Property(e => e.AnSeqWhNoIn)
                .HasDefaultValue(0)
                .HasColumnName("anSeqWhNoIn");
            entity.Property(e => e.AnSeqWhNoOut)
                .HasDefaultValue(0)
                .HasColumnName("anSeqWhNoOut");
            entity.Property(e => e.AnSequence).HasColumnName("anSequence");
            entity.Property(e => e.AnSigner1).HasColumnName("anSigner1");
            entity.Property(e => e.AnSigner2).HasColumnName("anSigner2");
            entity.Property(e => e.AnSigner3).HasColumnName("anSigner3");
            entity.Property(e => e.AnTradeLedgerNo).HasColumnName("anTradeLedgerNo");
            entity.Property(e => e.AnTransport)
                .HasColumnType("money")
                .HasColumnName("anTransport");
            entity.Property(e => e.AnUserChg)
                .HasDefaultValue(0)
                .HasColumnName("anUserChg");
            entity.Property(e => e.AnUserIns)
                .HasDefaultValue(0)
                .HasColumnName("anUserIns");
            entity.Property(e => e.AnValue)
                .HasColumnType("money")
                .HasColumnName("anValue");
            entity.Property(e => e.AnVat)
                .HasColumnType("money")
                .HasColumnName("anVAT");
            entity.Property(e => e.AnVatbase)
                .HasColumnType("money")
                .HasColumnName("anVATBase");
            entity.Property(e => e.AnVatin)
                .HasColumnType("money")
                .HasColumnName("anVATIn");
            entity.Property(e => e.AnVatpart)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anVATPart");

            entity.HasOne(d => d.AcDeptNavigation).WithMany(p => p.THeMoveAcDeptNavigations)
                .HasForeignKey(d => d.AcDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Move_tHE_SetSubj_16");

            entity.HasOne(d => d.AcDeptOutNavigation).WithMany(p => p.THeMoveAcDeptOutNavigations)
                .HasForeignKey(d => d.AcDeptOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Move_tHE_SetSubj_21");

            entity.HasOne(d => d.AcIssuerNavigation).WithMany(p => p.THeMoveAcIssuerNavigations)
                .HasForeignKey(d => d.AcIssuer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Move_tHE_SetSubj_3");

            entity.HasOne(d => d.AcPrsn3Navigation).WithMany(p => p.THeMoveAcPrsn3Navigations)
                .HasForeignKey(d => d.AcPrsn3)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Move_tHE_SetSubj_4");

            entity.HasOne(d => d.AcReceiverNavigation).WithMany(p => p.THeMoveAcReceiverNavigations)
                .HasForeignKey(d => d.AcReceiver)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Move_tHE_SetSubj_2");
        });

        modelBuilder.Entity<THeMoveItem>(entity =>
        {
            entity.HasKey(e => e.AnQid).HasName("IX_tHE_MoveItem_Id");

            entity.ToTable("tHE_MoveItem", tb =>
                {
                    tb.HasTrigger("gHE_MoveItemInsUD");
                    tb.HasTrigger("gHE_MoveItemUpdUD");
                    tb.HasTrigger("gHE_MoveItem_insert_instead_QId");
                    tb.HasTrigger("gHE_TrackMoveItemPrimaryKeyChanges");
                    tb.HasTrigger("gHE_TrackMoveItemPrimaryKeyDeletes");
                    tb.HasTrigger("gHE_tHE_MoveItem_Update_anNo_QId");
                    tb.HasTrigger("gPA_OnDelete_tHE_MoveItem");
                    tb.HasTrigger("gPA_tHE_MoveItem_UC");
                    tb.HasTrigger("pPA_Undo_tHE_MoveItem_Delete");
                    tb.HasTrigger("pPA_Undo_tHE_MoveItem_Update");
                });

            entity.HasIndex(e => e.AcUm3, "IX_MoveItem_tHE_SetUM_1659");

            entity.HasIndex(e => e.AnMoveQid, "IX_tHE_MoveItem_anMoveQId");

            entity.HasIndex(e => e.AcCostDrv, "iHE_MoveItem_CostDrv");

            entity.HasIndex(e => e.AcDept, "iHE_MoveItem_Depart");

            entity.HasIndex(e => new { e.AcIdent, e.AcKey, e.AnQty, e.AnStockPrice }, "iHE_MoveItem_Ident");

            entity.HasIndex(e => new { e.AcLnkKey, e.AnLnkNo, e.AnVtype }, "iHE_MoveItem_VKeyVNo").HasFillFactor(75);

            entity.HasIndex(e => new { e.AnMoveQid, e.AnQty }, "iHE_tHE_MoveItem_17");

            entity.HasIndex(e => new { e.AnRebate2, e.AnRebate3, e.AdDate }, "iHE_tHE_MoveItem_18");

            entity.HasIndex(e => new { e.AcVatcode, e.AnQty }, "iHE_tHE_MoveItem_19");

            entity.HasIndex(e => new { e.AcVatcodeTr, e.AnQty }, "iHE_tHE_MoveItem_20");

            entity.HasIndex(e => new { e.AcKey, e.AnStockPrice }, "iHE_tHE_MoveItem_21");

            entity.HasIndex(e => new { e.AnQid, e.AnQty }, "iHE_tHE_MoveItem_22");

            entity.HasIndex(e => e.AcDeclarForOriginType, "idx_tHE_MoveItem_10");

            entity.HasIndex(e => e.AcVatcodeTr, "idx_tHE_MoveItem_11");

            entity.HasIndex(e => e.AcUm, "idx_tHE_MoveItem_6");

            entity.HasIndex(e => e.AcVatcode, "idx_tHE_MoveItem_7");

            entity.HasIndex(e => e.AcAcctCr, "idx_tHE_MoveItem_8");

            entity.HasIndex(e => e.AcOrigin, "idx_tHE_MoveItem_9");

            entity.HasIndex(e => e.AcRmafault, "ix_FK_acRMAFault");

            entity.HasIndex(e => new { e.AcKey, e.AnNo }, "kHE_MoveItem_0").IsUnique();

            entity.Property(e => e.AnQid).HasColumnName("anQId");
            entity.Property(e => e.AcAcctClaim)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctClaim");
            entity.Property(e => e.AcAcctCr)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctCR");
            entity.Property(e => e.AcCostDrv)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCostDrv");
            entity.Property(e => e.AcDeclarForOriginType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDeclarForOriginType");
            entity.Property(e => e.AcDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDept");
            entity.Property(e => e.AcDistributeCosts)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acDistributeCosts");
            entity.Property(e => e.AcExemptFromVatstype)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acExemptFromVATSType");
            entity.Property(e => e.AcFieldL)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acFieldL");
            entity.Property(e => e.AcFiscReturn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acFiscReturn");
            entity.Property(e => e.AcIdent)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acIdent");
            entity.Property(e => e.AcKey)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acKey");
            entity.Property(e => e.AcLnkKey)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acLnkKey");
            entity.Property(e => e.AcMultiRmafault)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acMultiRMAFault");
            entity.Property(e => e.AcName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acName");
            entity.Property(e => e.AcNote)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNote");
            entity.Property(e => e.AcOrigin)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acOrigin");
            entity.Property(e => e.AcPackNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPackNum");
            entity.Property(e => e.AcRmafault)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRMAFault");
            entity.Property(e => e.AcTransferConnectDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("acTransferConnectDoc");
            entity.Property(e => e.AcUm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUM");
            entity.Property(e => e.AcUm2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acUM2");
            entity.Property(e => e.AcUm3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUM3");
            entity.Property(e => e.AcUmconverted)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acUMConverted");
            entity.Property(e => e.AcVatcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCode");
            entity.Property(e => e.AcVatcodeTr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCodeTR");
            entity.Property(e => e.AcWeighed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWeighed");
            entity.Property(e => e.AdDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDate");
            entity.Property(e => e.AdOrderCreated)
                .HasColumnType("datetime")
                .HasColumnName("adOrderCreated");
            entity.Property(e => e.AdTimeChg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeChg");
            entity.Property(e => e.AdTimeIns)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeIns");
            entity.Property(e => e.AnAllowedShortage).HasColumnName("anAllowedShortage");
            entity.Property(e => e.AnAllowedShortagePercent).HasColumnName("anAllowedShortagePercent");
            entity.Property(e => e.AnBeatShare)
                .HasDefaultValue(1.0)
                .HasColumnName("anBeatShare");
            entity.Property(e => e.AnDiffPriceRt)
                .HasComputedColumnSql("([anRTPriceP]-[anSalePrice])", false)
                .HasColumnName("anDiffPriceRT");
            entity.Property(e => e.AnDimVolume).HasColumnName("anDimVolume");
            entity.Property(e => e.AnDimWeight).HasColumnName("anDimWeight");
            entity.Property(e => e.AnDimWeightBrutto).HasColumnName("anDimWeightBrutto");
            entity.Property(e => e.AnDirectCost).HasColumnName("anDirectCost");
            entity.Property(e => e.AnDirectCostNfr).HasColumnName("anDirectCostNFR");
            entity.Property(e => e.AnDuty).HasColumnName("anDuty");
            entity.Property(e => e.AnDutyNfr).HasColumnName("anDutyNFR");
            entity.Property(e => e.AnExcise).HasColumnName("anExcise");
            entity.Property(e => e.AnExciseInc)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseInc");
            entity.Property(e => e.AnExciseIncP)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseIncP");
            entity.Property(e => e.AnExciseNotInc)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseNotInc");
            entity.Property(e => e.AnExciseNotIncP)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseNotIncP");
            entity.Property(e => e.AnExciseP).HasColumnName("anExciseP");
            entity.Property(e => e.AnFixPriceDiff).HasColumnName("anFixPriceDiff");
            entity.Property(e => e.AnInRtprice).HasColumnName("anInRTPrice");
            entity.Property(e => e.AnInRtpriceP).HasColumnName("anInRTPriceP");
            entity.Property(e => e.AnInSalePrice).HasColumnName("anInSalePrice");
            entity.Property(e => e.AnInWsprice).HasColumnName("anInWSPrice");
            entity.Property(e => e.AnInWsprice2).HasColumnName("anInWSPrice2");
            entity.Property(e => e.AnInWsprice2P).HasColumnName("anInWSPrice2P");
            entity.Property(e => e.AnInWspriceP).HasColumnName("anInWSPriceP");
            entity.Property(e => e.AnIncTax).HasColumnName("anIncTax");
            entity.Property(e => e.AnLnkNo).HasColumnName("anLnkNo");
            entity.Property(e => e.AnMoveQid)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("anMoveQId");
            entity.Property(e => e.AnNo).HasColumnName("anNo");
            entity.Property(e => e.AnPackQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPackQty");
            entity.Property(e => e.AnPayRebate).HasColumnName("anPayRebate");
            entity.Property(e => e.AnPckgQty)
                .HasDefaultValue(0.0)
                .HasColumnName("anPckgQty");
            entity.Property(e => e.AnPosxstock).HasColumnName("anPOSXStock");
            entity.Property(e => e.AnPrice).HasColumnName("anPrice");
            entity.Property(e => e.AnPriceCurrency).HasColumnName("anPriceCurrency");
            entity.Property(e => e.AnPrsn3Price)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPrsn3Price");
            entity.Property(e => e.AnPurExciseA).HasColumnName("anPurExciseA");
            entity.Property(e => e.AnPurExciseE).HasColumnName("anPurExciseE");
            entity.Property(e => e.AnPurExciseT).HasColumnName("anPurExciseT");
            entity.Property(e => e.AnPvdiscount)
                .HasColumnType("money")
                .HasColumnName("anPVDiscount");
            entity.Property(e => e.AnPvexcise)
                .HasColumnType("money")
                .HasColumnName("anPVExcise");
            entity.Property(e => e.AnPvforPay)
                .HasColumnType("money")
                .HasColumnName("anPVForPay");
            entity.Property(e => e.AnPvocbeatShare)
                .HasColumnType("money")
                .HasColumnName("anPVOCBeatShare");
            entity.Property(e => e.AnPvocbeatShareWoExc)
                .HasColumnType("money")
                .HasColumnName("anPVOCBeatShareWoExc");
            entity.Property(e => e.AnPvocdirectCost)
                .HasColumnType("money")
                .HasColumnName("anPVOCDirectCost");
            entity.Property(e => e.AnPvocdiscount)
                .HasColumnType("money")
                .HasColumnName("anPVOCDiscount");
            entity.Property(e => e.AnPvocduty)
                .HasColumnType("money")
                .HasColumnName("anPVOCDuty");
            entity.Property(e => e.AnPvocexcise)
                .HasColumnType("money")
                .HasColumnName("anPVOCExcise");
            entity.Property(e => e.AnPvocfixPriceDiff)
                .HasColumnType("money")
                .HasColumnName("anPVOCFixPriceDiff");
            entity.Property(e => e.AnPvocforPay)
                .HasColumnType("money")
                .HasColumnName("anPVOCForPay");
            entity.Property(e => e.AnPvocforPayWoExc)
                .HasColumnType("money")
                .HasColumnName("anPVOCForPayWoExc");
            entity.Property(e => e.AnPvocincVat)
                .HasColumnType("money")
                .HasColumnName("anPVOCIncVAT");
            entity.Property(e => e.AnPvocincVatwoExc)
                .HasColumnType("money")
                .HasColumnName("anPVOCIncVATWoExc");
            entity.Property(e => e.AnPvocnonBeatShare)
                .HasColumnType("money")
                .HasColumnName("anPVOCNonBeatShare");
            entity.Property(e => e.AnPvocnonBeatShareWoExc)
                .HasColumnType("money")
                .HasColumnName("anPVOCNonBeatShareWoExc");
            entity.Property(e => e.AnPvocstockValue)
                .HasColumnType("money")
                .HasColumnName("anPVOCStockValue");
            entity.Property(e => e.AnPvocsuppExcise)
                .HasColumnType("money")
                .HasColumnName("anPVOCSuppExcise");
            entity.Property(e => e.AnPvocsuppExciseIncSv)
                .HasColumnType("money")
                .HasColumnName("anPVOCSuppExciseIncSV");
            entity.Property(e => e.AnPvocsuppExciseIncVb)
                .HasColumnType("money")
                .HasColumnName("anPVOCSuppExciseIncVB");
            entity.Property(e => e.AnPvocsuppExciseIncVbincSuppForPay)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCSuppExciseIncVBIncSuppForPay");
            entity.Property(e => e.AnPvocsuppExciseNonIncVb)
                .HasColumnType("money")
                .HasColumnName("anPVOCSuppExciseNonIncVB");
            entity.Property(e => e.AnPvocsuppExciseNonIncVbincSuppForPay)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCSuppExciseNonIncVBIncSuppForPay");
            entity.Property(e => e.AnPvoctransport)
                .HasColumnType("money")
                .HasColumnName("anPVOCTransport");
            entity.Property(e => e.AnPvocvalue)
                .HasColumnType("money")
                .HasColumnName("anPVOCValue");
            entity.Property(e => e.AnPvocvat)
                .HasColumnType("money")
                .HasColumnName("anPVOCVAT");
            entity.Property(e => e.AnPvocvatbase)
                .HasColumnType("money")
                .HasColumnName("anPVOCVATBase");
            entity.Property(e => e.AnPvocvatbaseWoExc)
                .HasColumnType("money")
                .HasColumnName("anPVOCVATBaseWoExc");
            entity.Property(e => e.AnPvvalue)
                .HasColumnType("money")
                .HasColumnName("anPVValue");
            entity.Property(e => e.AnPvvat)
                .HasColumnType("money")
                .HasColumnName("anPVVAT");
            entity.Property(e => e.AnPvvatbase)
                .HasColumnType("money")
                .HasColumnName("anPVVATBase");
            entity.Property(e => e.AnQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQty");
            entity.Property(e => e.AnQtyConverted)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQtyConverted");
            entity.Property(e => e.AnQtyNfr).HasColumnName("anQtyNFR");
            entity.Property(e => e.AnQtyTemp)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQtyTemp");
            entity.Property(e => e.AnRebate).HasColumnName("anRebate");
            entity.Property(e => e.AnRebate1).HasColumnName("anRebate1");
            entity.Property(e => e.AnRebate2).HasColumnName("anRebate2");
            entity.Property(e => e.AnRebate3).HasColumnName("anRebate3");
            entity.Property(e => e.AnReserved)
                .HasDefaultValue(0.0)
                .HasColumnName("anReserved");
            entity.Property(e => e.AnRetailPrice)
                .HasColumnType("money")
                .HasColumnName("anRetailPrice");
            entity.Property(e => e.AnRound).HasColumnName("anRound");
            entity.Property(e => e.AnRtprice).HasColumnName("anRTPrice");
            entity.Property(e => e.AnRtpriceConverted).HasColumnName("anRTPriceConverted");
            entity.Property(e => e.AnRtpriceP).HasColumnName("anRTPriceP");
            entity.Property(e => e.AnSalePrice).HasColumnName("anSalePrice");
            entity.Property(e => e.AnStockChange)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anStockChange");
            entity.Property(e => e.AnStockIndex)
                .HasDefaultValue(100m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anStockIndex");
            entity.Property(e => e.AnStockNewValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anStockNewValue");
            entity.Property(e => e.AnStockPrice).HasColumnName("anStockPrice");
            entity.Property(e => e.AnStockQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anStockQty");
            entity.Property(e => e.AnStockValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anStockValue");
            entity.Property(e => e.AnTransport).HasColumnName("anTransport");
            entity.Property(e => e.AnTurnoverQty)
                .HasDefaultValue(0.0)
                .HasColumnName("anTurnoverQty");
            entity.Property(e => e.AnUmdecPlaces)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 4)")
                .HasColumnName("anUMDecPlaces");
            entity.Property(e => e.AnUmtoUm3)
                .HasDefaultValueSql("('1')")
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anUMToUM3");
            entity.Property(e => e.AnUserChg)
                .HasDefaultValue(0)
                .HasColumnName("anUserChg");
            entity.Property(e => e.AnUserIns)
                .HasDefaultValue(0)
                .HasColumnName("anUserIns");
            entity.Property(e => e.AnValueAfterDeduction)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anValueAfterDeduction");
            entity.Property(e => e.AnVat).HasColumnName("anVAT");
            entity.Property(e => e.AnVatValueAfterDeduction)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anVatValueAfterDeduction");
            entity.Property(e => e.AnVatafterDeduction)
                .HasDefaultValue(0.0)
                .HasColumnName("anVATAfterDeduction");
            entity.Property(e => e.AnVatin).HasColumnName("anVATIn");
            entity.Property(e => e.AnVtype).HasColumnName("anVType");
            entity.Property(e => e.AnWarrenty).HasColumnName("anWarrenty");
            entity.Property(e => e.AnWoprice)
                .HasDefaultValue(0.0)
                .HasColumnName("anWOPrice");
            entity.Property(e => e.AnWsprice).HasColumnName("anWSPrice");
            entity.Property(e => e.AnWsprice2).HasColumnName("anWSPrice2");
            entity.Property(e => e.AnWsprice2P).HasColumnName("anWSPrice2P");
            entity.Property(e => e.AnWspriceP).HasColumnName("anWSPriceP");

            entity.HasOne(d => d.AcDeptNavigation).WithMany(p => p.THeMoveItems)
                .HasForeignKey(d => d.AcDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_MoveItem_tHE_SetSubj_8");

            entity.HasOne(d => d.AcIdentNavigation).WithMany(p => p.THeMoveItems)
                .HasForeignKey(d => d.AcIdent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_MoveItem_tHE_SetItem_2");

            entity.HasOne(d => d.AnMoveQ).WithMany(p => p.THeMoveItems)
                .HasForeignKey(d => d.AnMoveQid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_MoveItem_tHE_Move_18");
        });

        modelBuilder.Entity<THeOrder>(entity =>
        {
            entity.HasKey(e => e.AnQid).HasName("IX_tHE_Order_Id");

            entity.ToTable("tHE_Order", tb =>
                {
                    tb.HasTrigger("gHE_OrderInsUD");
                    tb.HasTrigger("gHE_OrderUpdUD");
                    tb.HasTrigger("gHE_TrackOrderPrimaryKeyChanges");
                    tb.HasTrigger("gHE_TrackOrderPrimaryKeyDeletes");
                    tb.HasTrigger("gHE_tHE_Order_Update_acKey_QId");
                    tb.HasTrigger("gPA_OnDelete_tHE_Order");
                    tb.HasTrigger("gPA_tHE_Order_UC");
                    tb.HasTrigger("pPA_Undo_tHE_Order_Delete");
                    tb.HasTrigger("pPA_Undo_tHE_Order_Update");
                });

            entity.HasIndex(e => new { e.AcDocType, e.AcStatus, e.AcWarehouse }, "IX_tHE_Order_DocType_Status_Warehouse");

            entity.HasIndex(e => new { e.AcDocType, e.AdTimeIns }, "IX_tHE_Order_DocType_TimeIns");

            entity.HasIndex(e => e.AcInsertedFrom, "IX_tHE_Order_acInsertedFrom");

            entity.HasIndex(e => new { e.AcConsignee, e.AcKey }, "iHE_Order_Consignee");

            entity.HasIndex(e => e.AdDate, "iHE_Order_Date");

            entity.HasIndex(e => e.AdDateValid, "iHE_Order_DateValid");

            entity.HasIndex(e => new { e.AcDocType, e.AcKey }, "iHE_Order_DocType");

            entity.HasIndex(e => e.AcDocType, "iHE_Order_DocType_1");

            entity.HasIndex(e => new { e.AcDocType, e.AcStatus, e.AdDateValid }, "iHE_Order_DocType_Status_DateValid");

            entity.HasIndex(e => new { e.AcReceiver, e.AcKey }, "iHE_Order_Receiver");

            entity.HasIndex(e => e.AcWarehouse, "idx_tHE_Order_10");

            entity.HasIndex(e => e.AcStatement, "idx_tHE_Order_11").HasFillFactor(75);

            entity.HasIndex(e => e.AcCurrency, "idx_tHE_Order_12");

            entity.HasIndex(e => e.AcDept, "idx_tHE_Order_13");

            entity.HasIndex(e => e.AcParity, "idx_tHE_Order_14");

            entity.HasIndex(e => e.AcParityPost, "idx_tHE_Order_15");

            entity.HasIndex(e => e.AnNoteClerk, "idx_tHE_Order_16");

            entity.HasIndex(e => e.AnSigner1, "idx_tHE_Order_17");

            entity.HasIndex(e => e.AnSigner2, "idx_tHE_Order_18");

            entity.HasIndex(e => e.AnSigner3, "idx_tHE_Order_19");

            entity.HasIndex(e => e.AcPayMethod, "idx_tHE_Order_7");

            entity.HasIndex(e => e.AcDelivery, "idx_tHE_Order_8");

            entity.HasIndex(e => e.AnClerk, "idx_tHE_Order_9");

            entity.HasIndex(e => new { e.AcDocType, e.AcStatus }, "ix_FK_acDocType_acStatus");

            entity.HasIndex(e => e.AcKey, "kHE_Order_0").IsUnique();

            entity.Property(e => e.AnQid).HasColumnName("anQId");
            entity.Property(e => e.AcBuyerCostCenterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acBuyerCostCenterId");
            entity.Property(e => e.AcBuyerId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("acBuyerId");
            entity.Property(e => e.AcCode1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acCode1");
            entity.Property(e => e.AcCode2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acCode2");
            entity.Property(e => e.AcCode3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acCode3");
            entity.Property(e => e.AcConfrm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acConfrm");
            entity.Property(e => e.AcConsignee)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acConsignee");
            entity.Property(e => e.AcContactPrsn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acContactPrsn");
            entity.Property(e => e.AcContactPrsn3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acContactPrsn3");
            entity.Property(e => e.AcCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCurrency");
            entity.Property(e => e.AcDelivery)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDelivery");
            entity.Property(e => e.AcDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDept");
            entity.Property(e => e.AcDoc1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDoc1");
            entity.Property(e => e.AcDoc2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDoc2");
            entity.Property(e => e.AcDocType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocType");
            entity.Property(e => e.AcFieldSa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSA");
            entity.Property(e => e.AcFieldSb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSB");
            entity.Property(e => e.AcFieldSc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSC");
            entity.Property(e => e.AcFieldSd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSD");
            entity.Property(e => e.AcFieldSe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSE");
            entity.Property(e => e.AcFieldSf)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSF");
            entity.Property(e => e.AcFieldSg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSG");
            entity.Property(e => e.AcFieldSh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSH");
            entity.Property(e => e.AcFieldSi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSI");
            entity.Property(e => e.AcFieldSj)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSJ");
            entity.Property(e => e.AcFinished)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acFinished");
            entity.Property(e => e.AcFiscStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("acFiscStatus");
            entity.Property(e => e.AcForm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acForm");
            entity.Property(e => e.AcInsertedFrom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength()
                .HasColumnName("acInsertedFrom");
            entity.Property(e => e.AcInternalNote)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acInternalNote");
            entity.Property(e => e.AcKey)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acKey");
            entity.Property(e => e.AcKeyView)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasComputedColumnSql("((((left([acKey],(2))+'-')+substring([acKey],(3),(4)))+'-')+right([acKey],(6)))", true)
                .HasColumnName("acKeyView");
            entity.Property(e => e.AcLoyaltyCard)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("acLoyaltyCard");
            entity.Property(e => e.AcNote)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNote");
            entity.Property(e => e.AcParity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acParity");
            entity.Property(e => e.AcParityPost)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acParityPost");
            entity.Property(e => e.AcPayMethod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayMethod");
            entity.Property(e => e.AcPriceRate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .IsFixedLength()
                .HasColumnName("acPriceRate");
            entity.Property(e => e.AcReceiver)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acReceiver");
            entity.Property(e => e.AcRefNo1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo1");
            entity.Property(e => e.AcRefNo2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo2");
            entity.Property(e => e.AcRefNo3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo3");
            entity.Property(e => e.AcRefNo4)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRefNo4");
            entity.Property(e => e.AcRetailSale)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acRetailSale");
            entity.Property(e => e.AcRoundVatonDoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acRoundVATOnDoc");
            entity.Property(e => e.AcStatement)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acStatement");
            entity.Property(e => e.AcStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acStatus");
            entity.Property(e => e.AcTrailerRegistrationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acTrailerRegistrationNumber");
            entity.Property(e => e.AcTransporter)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acTransporter");
            entity.Property(e => e.AcTriangTrans)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acTriangTrans");
            entity.Property(e => e.AcUpncode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUPNCode");
            entity.Property(e => e.AcUpncontrolNum)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUPNControlNum");
            entity.Property(e => e.AcUpnprint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .HasColumnName("acUPNPrint");
            entity.Property(e => e.AcUpnreference)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUPNReference");
            entity.Property(e => e.AcVehicleRegistrationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVehicleRegistrationNumber");
            entity.Property(e => e.AcWarehouse)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acWarehouse");
            entity.Property(e => e.AcWayOfSale)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("K")
                .IsFixedLength()
                .HasColumnName("acWayOfSale");
            entity.Property(e => e.AcWebid)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("acWEBID");
            entity.Property(e => e.AdDate)
                .HasDefaultValueSql("(dateadd(day,datediff(day,(0),getdate()),(0)))")
                .HasColumnType("smalldatetime")
                .HasColumnName("adDate");
            entity.Property(e => e.AdDateDoc1)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateDoc1");
            entity.Property(e => e.AdDateDoc2)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateDoc2");
            entity.Property(e => e.AdDateTimePrint)
                .HasColumnType("datetime")
                .HasColumnName("adDateTimePrint");
            entity.Property(e => e.AdDateValid)
                .HasDefaultValueSql("(dateadd(day,datediff(day,(0),getdate()),(0)))")
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateValid");
            entity.Property(e => e.AdDeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("adDeliveryDate");
            entity.Property(e => e.AdDeliveryDeadline)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDeliveryDeadline");
            entity.Property(e => e.AdFieldDa)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDA");
            entity.Property(e => e.AdFieldDb)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDB");
            entity.Property(e => e.AdFieldDc)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDC");
            entity.Property(e => e.AdFieldDd)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDD");
            entity.Property(e => e.AdSigned1)
                .HasColumnType("datetime")
                .HasColumnName("adSigned1");
            entity.Property(e => e.AdSigned2)
                .HasColumnType("datetime")
                .HasColumnName("adSigned2");
            entity.Property(e => e.AdSigned3)
                .HasColumnType("datetime")
                .HasColumnName("adSigned3");
            entity.Property(e => e.AdTimeChg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeChg");
            entity.Property(e => e.AdTimeIns)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeIns");
            entity.Property(e => e.AdTransportDate)
                .HasColumnType("datetime")
                .HasColumnName("adTransportDate");
            entity.Property(e => e.AnBnkAcctNo).HasColumnName("anBnkAcctNo");
            entity.Property(e => e.AnBuyerCostCenterIdDef)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("anBuyerCostCenterIdDef");
            entity.Property(e => e.AnBuyerIdDef)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("anBuyerIdDef");
            entity.Property(e => e.AnClerk).HasColumnName("anClerk");
            entity.Property(e => e.AnCurrValue)
                .HasColumnType("money")
                .HasColumnName("anCurrValue");
            entity.Property(e => e.AnDaysForPayment).HasColumnName("anDaysForPayment");
            entity.Property(e => e.AnDaysForValid).HasColumnName("anDaysForValid");
            entity.Property(e => e.AnDeliveryDays)
                .HasDefaultValue(0)
                .HasColumnName("anDeliveryDays");
            entity.Property(e => e.AnDeliveryPriority).HasColumnName("anDeliveryPriority");
            entity.Property(e => e.AnDiscount)
                .HasColumnType("money")
                .HasColumnName("anDiscount");
            entity.Property(e => e.AnFgnBankNo)
                .HasDefaultValue(0)
                .HasColumnName("anFgnBankNo");
            entity.Property(e => e.AnFieldNa)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNA");
            entity.Property(e => e.AnFieldNb)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNB");
            entity.Property(e => e.AnFieldNc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNC");
            entity.Property(e => e.AnFieldNd)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldND");
            entity.Property(e => e.AnFieldNe)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNE");
            entity.Property(e => e.AnFieldNf)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNF");
            entity.Property(e => e.AnFieldNg)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNG");
            entity.Property(e => e.AnFieldNh)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNH");
            entity.Property(e => e.AnFieldNi)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNI");
            entity.Property(e => e.AnFieldNj)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNJ");
            entity.Property(e => e.AnForPay)
                .HasColumnType("money")
                .HasColumnName("anForPay");
            entity.Property(e => e.AnFxrate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFXRate");
            entity.Property(e => e.AnNoteClerk).HasColumnName("anNoteClerk");
            entity.Property(e => e.AnOurBankAcctNo)
                .HasDefaultValue(0)
                .HasColumnName("anOurBankAcctNo");
            entity.Property(e => e.AnOurBankAcctNoFgn)
                .HasDefaultValue(0)
                .HasColumnName("anOurBankAcctNoFgn");
            entity.Property(e => e.AnRoomTableId).HasColumnName("anRoomTableID");
            entity.Property(e => e.AnRoundItem)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundItem");
            entity.Property(e => e.AnRoundItemFc)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundItemFC");
            entity.Property(e => e.AnRoundPrice)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundPrice");
            entity.Property(e => e.AnRoundValue)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundValue");
            entity.Property(e => e.AnRoundValueOc)
                .HasDefaultValue(0.0001m)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("anRoundValueOC");
            entity.Property(e => e.AnSigner1).HasColumnName("anSigner1");
            entity.Property(e => e.AnSigner2).HasColumnName("anSigner2");
            entity.Property(e => e.AnSigner3).HasColumnName("anSigner3");
            entity.Property(e => e.AnUserChg)
                .HasDefaultValue(0)
                .HasColumnName("anUserChg");
            entity.Property(e => e.AnUserIns)
                .HasDefaultValue(0)
                .HasColumnName("anUserIns");
            entity.Property(e => e.AnValue)
                .HasColumnType("money")
                .HasColumnName("anValue");
            entity.Property(e => e.AnVat)
                .HasColumnType("money")
                .HasColumnName("anVAT");

            entity.HasOne(d => d.AcConsigneeNavigation).WithMany(p => p.THeOrderAcConsigneeNavigations)
                .HasForeignKey(d => d.AcConsignee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Order_tHE_SetSubj_2");

            entity.HasOne(d => d.AcDeptNavigation).WithMany(p => p.THeOrderAcDeptNavigations)
                .HasForeignKey(d => d.AcDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Order_tHE_SetSubj_10");

            entity.HasOne(d => d.AcReceiverNavigation).WithMany(p => p.THeOrderAcReceiverNavigations)
                .HasForeignKey(d => d.AcReceiver)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Order_tHE_SetSubj_3");

            entity.HasOne(d => d.AcTransporterNavigation).WithMany(p => p.THeOrderAcTransporterNavigations)
                .HasForeignKey(d => d.AcTransporter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Order_tHE_SetSubj_20");

            entity.HasOne(d => d.AcWarehouseNavigation).WithMany(p => p.THeOrderAcWarehouseNavigations)
                .HasForeignKey(d => d.AcWarehouse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_Order_tHE_SetSubj_7");
        });

        modelBuilder.Entity<THeOrderItem>(entity =>
        {
            entity.HasKey(e => e.AnQid).HasName("IX_tHE_OrderItem_Id");

            entity.ToTable("tHE_OrderItem", tb =>
                {
                    tb.HasTrigger("gHE_OrderItemInsUD");
                    tb.HasTrigger("gHE_OrderItemUpdUD");
                    tb.HasTrigger("gHE_OrderItem_insert_instead_QId");
                    tb.HasTrigger("gHE_TrackOrderItemPrimaryKeyChanges");
                    tb.HasTrigger("gHE_TrackOrderItemPrimaryKeyDeletes");
                    tb.HasTrigger("gHE_tHE_OrderItem_Update_anNo_QId");
                    tb.HasTrigger("gHF_Order2PlanItem");
                    tb.HasTrigger("gHF_Order2PlanItem_AT");
                    tb.HasTrigger("gHF_Order2PlanSBOM");
                    tb.HasTrigger("gPA_OnDelete_tHE_OrderItem");
                    tb.HasTrigger("gPA_tHE_OrderItem_UC");
                    tb.HasTrigger("pPA_Undo_tHE_OrderItem_Delete");
                    tb.HasTrigger("pPA_Undo_tHE_OrderItem_Update");
                });

            entity.HasIndex(e => e.AnOrderQid, "IX_tHE_OrderItem_anOrderQId");

            entity.HasIndex(e => e.AcCostDrv, "iHE_OrderItem_CostDrv");

            entity.HasIndex(e => e.AcIdent, "iHE_OrderItem_Ident");

            entity.HasIndex(e => e.AcUm, "idx_tHE_OrderItem_4");

            entity.HasIndex(e => e.AcVatcode, "idx_tHE_OrderItem_5");

            entity.HasIndex(e => e.AcDept, "idx_tHE_OrderItem_6");

            entity.HasIndex(e => new { e.AcKey, e.AnNo }, "kHE_OrderItem_0").IsUnique();

            entity.HasIndex(e => new { e.AcDept, e.AcCostDrv }, "tHE_OrderItem_10");

            entity.HasIndex(e => new { e.AcKey, e.AnVat }, "tHE_OrderItem_9");

            entity.Property(e => e.AnQid).HasColumnName("anQId");
            entity.Property(e => e.AcCostDrv)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCostDrv");
            entity.Property(e => e.AcDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDept");
            entity.Property(e => e.AcFixedAsset)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFixedAsset");
            entity.Property(e => e.AcIdent)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acIdent");
            entity.Property(e => e.AcKey)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acKey");
            entity.Property(e => e.AcLnkKey)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acLnkKey");
            entity.Property(e => e.AcName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acName");
            entity.Property(e => e.AcNote)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNote");
            entity.Property(e => e.AcOrigin)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acOrigin");
            entity.Property(e => e.AcPackNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPackNum");
            entity.Property(e => e.AcPriority)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acPriority");
            entity.Property(e => e.AcPrstUmtime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acPrstUMTime");
            entity.Property(e => e.AcUm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUM");
            entity.Property(e => e.AcUm2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acUM2");
            entity.Property(e => e.AcUmconverted)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acUMConverted");
            entity.Property(e => e.AcVatcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCode");
            entity.Property(e => e.AcWeighed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWeighed");
            entity.Property(e => e.AcWorker)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acWorker");
            entity.Property(e => e.AdDeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("adDeliveryDate");
            entity.Property(e => e.AdDeliveryDeadline)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDeliveryDeadline");
            entity.Property(e => e.AdEndTime)
                .HasColumnType("datetime")
                .HasColumnName("adEndTime");
            entity.Property(e => e.AdStartTime)
                .HasColumnType("datetime")
                .HasColumnName("adStartTime");
            entity.Property(e => e.AdTimeChg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeChg");
            entity.Property(e => e.AdTimeIns)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeIns");
            entity.Property(e => e.AnColorCode).HasColumnName("anColorCode");
            entity.Property(e => e.AnDimVolume).HasColumnName("anDimVolume");
            entity.Property(e => e.AnDimWeight).HasColumnName("anDimWeight");
            entity.Property(e => e.AnDimWeightBrutto).HasColumnName("anDimWeightBrutto");
            entity.Property(e => e.AnExcise).HasColumnName("anExcise");
            entity.Property(e => e.AnExciseInc)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseInc");
            entity.Property(e => e.AnExciseIncP)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseIncP");
            entity.Property(e => e.AnExciseNotInc)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseNotInc");
            entity.Property(e => e.AnExciseNotIncP)
                .HasDefaultValue(0.0)
                .HasColumnName("anExciseNotIncP");
            entity.Property(e => e.AnExciseP).HasColumnName("anExciseP");
            entity.Property(e => e.AnLastprice).HasColumnName("anLastprice");
            entity.Property(e => e.AnLnkNo).HasColumnName("anLnkNo");
            entity.Property(e => e.AnNo).HasColumnName("anNo");
            entity.Property(e => e.AnOrderQid)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("anOrderQId");
            entity.Property(e => e.AnPackQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPackQty");
            entity.Property(e => e.AnPrice).HasColumnName("anPrice");
            entity.Property(e => e.AnPriceCurrency)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPriceCurrency");
            entity.Property(e => e.AnPrstTime).HasColumnName("anPrstTime");
            entity.Property(e => e.AnPvdiscount)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVDiscount");
            entity.Property(e => e.AnPvexcise)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVExcise");
            entity.Property(e => e.AnPvforPay)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVForPay");
            entity.Property(e => e.AnPvocdiscount)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCDiscount");
            entity.Property(e => e.AnPvocexcise)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCExcise");
            entity.Property(e => e.AnPvocforPay)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCForPay");
            entity.Property(e => e.AnPvocvalue)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCValue");
            entity.Property(e => e.AnPvocvat)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCVAT");
            entity.Property(e => e.AnPvocvatbase)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVOCVATBase");
            entity.Property(e => e.AnPvvalue)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVValue");
            entity.Property(e => e.AnPvvat)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVVAT");
            entity.Property(e => e.AnPvvatbase)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anPVVATBase");
            entity.Property(e => e.AnQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQty");
            entity.Property(e => e.AnQtyConverted)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQtyConverted");
            entity.Property(e => e.AnQtyDispDoc)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQtyDispDoc");
            entity.Property(e => e.AnRebate).HasColumnName("anRebate");
            entity.Property(e => e.AnRebate1).HasColumnName("anRebate1");
            entity.Property(e => e.AnRebate2).HasColumnName("anRebate2");
            entity.Property(e => e.AnRebate3).HasColumnName("anRebate3");
            entity.Property(e => e.AnReserved)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anReserved");
            entity.Property(e => e.AnRetailPrice)
                .HasColumnType("money")
                .HasColumnName("anRetailPrice");
            entity.Property(e => e.AnRound).HasColumnName("anRound");
            entity.Property(e => e.AnRtprice)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anRTPrice");
            entity.Property(e => e.AnRtpriceConverted).HasColumnName("anRTPriceConverted");
            entity.Property(e => e.AnSalePrice)
                .HasColumnType("money")
                .HasColumnName("anSalePrice");
            entity.Property(e => e.AnUmdecPlaces)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 4)")
                .HasColumnName("anUMDecPlaces");
            entity.Property(e => e.AnUserChg)
                .HasDefaultValue(0)
                .HasColumnName("anUserChg");
            entity.Property(e => e.AnUserIns)
                .HasDefaultValue(0)
                .HasColumnName("anUserIns");
            entity.Property(e => e.AnVariant).HasColumnName("anVariant");
            entity.Property(e => e.AnVat).HasColumnName("anVAT");

            entity.HasOne(d => d.AcDeptNavigation).WithMany(p => p.THeOrderItems)
                .HasForeignKey(d => d.AcDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_OrderItem_tHE_SetSubj_5");

            entity.HasOne(d => d.AcIdentNavigation).WithMany(p => p.THeOrderItems)
                .HasForeignKey(d => d.AcIdent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_OrderItem_tHE_SetItem_2");

            entity.HasOne(d => d.AnOrderQ).WithMany(p => p.THeOrderItems)
                .HasForeignKey(d => d.AnOrderQid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_OrderItem_tHE_Order_9");
        });

        modelBuilder.Entity<THeSetItem>(entity =>
        {
            entity.HasKey(e => e.AcIdent).HasName("kHE_SetItem_0");

            entity.ToTable("tHE_SetItem", tb =>
                {
                    tb.HasTrigger("gHE_SetItemInsUD");
                    tb.HasTrigger("gHE_SetItemUpdUD");
                    tb.HasTrigger("gHE_TrackItemPrimaryKeyChanges");
                    tb.HasTrigger("gHE_TrackItemPrimaryKeyDeletes");
                    tb.HasTrigger("gHF_SetItem2SetsPrSt");
                    tb.HasTrigger("gHF_SetItem2SetsPrStVariants");
                    tb.HasTrigger("gPA_OnDelete_tHE_SetItem");
                    tb.HasTrigger("gPA_tHE_SetItem_UC");
                });

            entity.HasIndex(e => new { e.AcActive, e.AcIdent }, "IX_tHE_SetItem_Active_Ident").HasFillFactor(75);

            entity.HasIndex(e => e.AnQid, "IX_tHE_SetItem_Id")
                .IsUnique()
                .HasFillFactor(75);

            entity.HasIndex(e => e.AdTimeChg, "IX_tHE_SetItem_TimeChg");

            entity.HasIndex(e => e.AcClassif, "iHE_SetItem_Classif");

            entity.HasIndex(e => e.AcCode, "iHE_SetItem_Code");

            entity.HasIndex(e => e.AcName, "iHE_SetItem_Name");

            entity.HasIndex(e => e.AcSupplier, "iHE_SetItem_Supplier");

            entity.HasIndex(e => e.AcSerialNo, "iX_tHE_SetItem_SerialNo");

            entity.HasIndex(e => e.AcUm, "idx_tHE_SetItem_10").HasFillFactor(75);

            entity.HasIndex(e => e.AcUm2, "idx_tHE_SetItem_11");

            entity.HasIndex(e => e.AcVatcode, "idx_tHE_SetItem_12");

            entity.HasIndex(e => e.AcVatcodeLow, "idx_tHE_SetItem_13");

            entity.HasIndex(e => e.AcCustTariff, "idx_tHE_SetItem_16");

            entity.HasIndex(e => e.AcOrigin, "idx_tHE_SetItem_18");

            entity.HasIndex(e => e.AcDeclarForOriginType, "idx_tHE_SetItem_19");

            entity.HasIndex(e => e.AcAcct, "idx_tHE_SetItem_20");

            entity.HasIndex(e => e.AcDept, "idx_tHE_SetItem_21");

            entity.HasIndex(e => e.AcColumn, "idx_tHE_SetItem_25");

            entity.HasIndex(e => e.AcUm3, "idx_tHE_SetItem_26");

            entity.HasIndex(e => e.AcCostDrv, "idx_tHE_SetItem_29");

            entity.HasIndex(e => e.AcClassif2, "idx_tHE_SetItem_6");

            entity.HasIndex(e => e.AcSetOfItem, "idx_tHE_SetItem_7");

            entity.HasIndex(e => e.AcFormula, "idx_tHE_SetItem_8");

            entity.HasIndex(e => e.AcCurrency, "idx_tHE_SetItem_9");

            entity.HasIndex(e => e.AcAcctIncome, "ix_FK_acAcctIncome");

            entity.HasIndex(e => e.AcDroesubject, "ix_FK_acDROESubject");

            entity.HasIndex(e => e.AcDocTypeOrdSupp, "ix_FK_acDocTypeOrdSupp");

            entity.HasIndex(e => e.AcDocTypeProd, "ix_FK_acDocTypeProd");

            entity.HasIndex(e => e.AcInFlowOutFlow, "ix_FK_acInFlowOutFlow");

            entity.HasIndex(e => e.AcPackSlopak, "ix_FK_acPackSLOPAK");

            entity.HasIndex(e => e.AcPurchCurr, "ix_FK_acPurchCurr");

            entity.HasIndex(e => e.AcUmdim1, "ix_FK_acUMDim1");

            entity.HasIndex(e => e.AcUmdim2, "ix_FK_acUMDim2");

            entity.HasIndex(e => e.AcUmmarkLabel, "ix_FK_acUMMarkLabel");

            entity.HasIndex(e => e.AcUmseries, "ix_FK_acUMSeries");

            entity.HasIndex(e => e.AcUsedTyre, "ix_FK_acUsedTyre");

            entity.HasIndex(e => e.AcWastePack, "ix_FK_acWastePack");

            entity.HasIndex(e => e.AcWstEeequip, "ix_FK_acWstEEEquip");

            entity.HasIndex(e => e.AnPrStCheckUserId, "ix_FK_anPrStCheckUserID");

            entity.HasIndex(e => e.AnPrStInsertUserId, "ix_FK_anPrStInsertUserID");

            entity.HasIndex(e => e.AnPrStUpdateUserId, "ix_FK_anPrStUpdateUserID");

            entity.Property(e => e.AcIdent)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acIdent");
            entity.Property(e => e.AbConvertToUmForPos)
                .HasDefaultValue(false)
                .HasColumnName("abConvertToUmForPos");
            entity.Property(e => e.AbIcon).HasColumnName("abIcon");
            entity.Property(e => e.AbRoundQtyToInt).HasColumnName("abRoundQtyToInt");
            entity.Property(e => e.AcAcct)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcct");
            entity.Property(e => e.AcAcctBuyVasale)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctBuyVASale");
            entity.Property(e => e.AcAcctIncome)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctIncome");
            entity.Property(e => e.AcAcctNotTaxDeduct)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("acAcctNotTaxDeduct");
            entity.Property(e => e.AcActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acActive");
            entity.Property(e => e.AcBackPacking)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acBackPacking");
            entity.Property(e => e.AcBst)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("acBST");
            entity.Property(e => e.AcBullId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("acBullId");
            entity.Property(e => e.AcClassProdByAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("acClassProdByAct");
            entity.Property(e => e.AcClassif)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acClassif");
            entity.Property(e => e.AcClassif2)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acClassif2");
            entity.Property(e => e.AcCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCode");
            entity.Property(e => e.AcColumn)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acColumn");
            entity.Property(e => e.AcCostDrv)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCostDrv");
            entity.Property(e => e.AcCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCurrency");
            entity.Property(e => e.AcCustTariff)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCustTariff");
            entity.Property(e => e.AcDateDue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acDateDue");
            entity.Property(e => e.AcDeclarForOrigin)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDeclarForOrigin");
            entity.Property(e => e.AcDeclarForOriginType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDeclarForOriginType");
            entity.Property(e => e.AcDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDept");
            entity.Property(e => e.AcDescr)
                .IsUnicode(false)
                .HasColumnName("acDescr");
            entity.Property(e => e.AcDescrRtf).HasColumnName("acDescrRTF");
            entity.Property(e => e.AcDocTypeIssue)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocTypeIssue");
            entity.Property(e => e.AcDocTypeOrdSupp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocTypeOrdSupp");
            entity.Property(e => e.AcDocTypeProd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acDocTypeProd");
            entity.Property(e => e.AcDroe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acDROE");
            entity.Property(e => e.AcDroesubject)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDROESubject");
            entity.Property(e => e.AcEnableChgPrSt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acEnableChgPrSt");
            entity.Property(e => e.AcEnvrmntCost)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acEnvrmntCost");
            entity.Property(e => e.AcEvidence)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acEvidence");
            entity.Property(e => e.AcFieldSa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSA");
            entity.Property(e => e.AcFieldSb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSB");
            entity.Property(e => e.AcFieldSc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSC");
            entity.Property(e => e.AcFieldSd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSD");
            entity.Property(e => e.AcFieldSe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSE");
            entity.Property(e => e.AcFieldSf)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSF");
            entity.Property(e => e.AcFieldSg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSG");
            entity.Property(e => e.AcFieldSh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSH");
            entity.Property(e => e.AcFieldSi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSI");
            entity.Property(e => e.AcFieldSj)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSJ");
            entity.Property(e => e.AcForSubject)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acForSubject");
            entity.Property(e => e.AcFormula)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFormula");
            entity.Property(e => e.AcFormulaRt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFormulaRT");
            entity.Property(e => e.AcHttppath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acHTTPPath");
            entity.Property(e => e.AcInFlowOutFlow)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acInFlowOutFlow");
            entity.Property(e => e.AcIsReturnPack)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acIsReturnPack");
            entity.Property(e => e.AcMakeCalc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("C")
                .IsFixedLength()
                .HasColumnName("acMakeCalc");
            entity.Property(e => e.AcName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acName");
            entity.Property(e => e.AcNote)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("acNote");
            entity.Property(e => e.AcOrderTransInMf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("K")
                .IsFixedLength()
                .HasColumnName("acOrderTransInMF");
            entity.Property(e => e.AcOrigin)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acOrigin");
            entity.Property(e => e.AcPackSlopak)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPackSLOPAK");
            entity.Property(e => e.AcPackSlopaktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acPackSLOPAKType");
            entity.Property(e => e.AcPackagingType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .IsFixedLength()
                .HasColumnName("acPackagingType");
            entity.Property(e => e.AcPacking)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acPacking");
            entity.Property(e => e.AcPicture).HasColumnName("acPicture");
            entity.Property(e => e.AcPosprinterId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPOSPrinterId");
            entity.Property(e => e.AcPrintTechProc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acPrintTechProc");
            entity.Property(e => e.AcPrstPrice)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acPrstPrice");
            entity.Property(e => e.AcPrstUmtime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("H")
                .IsFixedLength()
                .HasColumnName("acPrstUMTime");
            entity.Property(e => e.AcPrtPicture).HasColumnName("acPrtPicture");
            entity.Property(e => e.AcPurchCurr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPurchCurr");
            entity.Property(e => e.AcQtyInCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acQtyInCode");
            entity.Property(e => e.AcQtyNotToKol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acQtyNotToKol");
            entity.Property(e => e.AcReportDeclar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acReportDeclar");
            entity.Property(e => e.AcSerialNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("acSerialNo");
            entity.Property(e => e.AcSerialnoDueType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("M")
                .IsFixedLength()
                .HasColumnName("acSerialnoDueType");
            entity.Property(e => e.AcSetOfItem)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSetOfItem");
            entity.Property(e => e.AcShowAtena)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acShowAtena");
            entity.Property(e => e.AcStandardize)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acStandardize");
            entity.Property(e => e.AcStretchPicture)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acStretchPicture");
            entity.Property(e => e.AcSupplier)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSupplier");
            entity.Property(e => e.AcTechProcedure)
                .IsUnicode(false)
                .HasColumnName("acTechProcedure");
            entity.Property(e => e.AcTechProcedureRtf).HasColumnName("acTechProcedureRTF");
            entity.Property(e => e.AcTouchPicture).HasColumnName("acTouchPicture");
            entity.Property(e => e.AcTransferredWs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acTransferredWS");
            entity.Property(e => e.AcUm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUM");
            entity.Property(e => e.AcUm2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUM2");
            entity.Property(e => e.AcUm3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUM3");
            entity.Property(e => e.AcUmForPos)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("acUmForPos");
            entity.Property(e => e.AcUmdim1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUMDim1");
            entity.Property(e => e.AcUmdim2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUMDim2");
            entity.Property(e => e.AcUmmarkLabel)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUMMarkLabel");
            entity.Property(e => e.AcUmseries)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUMSeries");
            entity.Property(e => e.AcUseAsCostOnIntrastat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acUseAsCostOnIntrastat");
            entity.Property(e => e.AcUseAsCostOnVatba)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acUseAsCostOnVATBA");
            entity.Property(e => e.AcUsedTyre)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acUsedTyre");
            entity.Property(e => e.AcVatcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCode");
            entity.Property(e => e.AcVatcodeLow)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCodeLow");
            entity.Property(e => e.AcVatcodeReceive)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCodeReceive");
            entity.Property(e => e.AcVatcodeReduced)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("acVATCodeReduced");
            entity.Property(e => e.AcVehiclePart)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acVehiclePart");
            entity.Property(e => e.AcWastePack)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acWastePack");
            entity.Property(e => e.AcWebShopItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWebShopItem");
            entity.Property(e => e.AcWeighableItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWeighableItem");
            entity.Property(e => e.AcWstEeequip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acWstEEEquip");
            entity.Property(e => e.AdDiscountBegin)
                .HasColumnType("datetime")
                .HasColumnName("adDiscountBegin");
            entity.Property(e => e.AdDiscountEnd)
                .HasColumnType("datetime")
                .HasColumnName("adDiscountEnd");
            entity.Property(e => e.AdFieldDa)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDA");
            entity.Property(e => e.AdFieldDb)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDB");
            entity.Property(e => e.AdFieldDc)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDC");
            entity.Property(e => e.AdFieldDd)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDD");
            entity.Property(e => e.AdPrStCheckTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adPrStCheckTime");
            entity.Property(e => e.AdPrStInsertTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adPrStInsertTime");
            entity.Property(e => e.AdPrStUpdateTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("adPrStUpdateTime");
            entity.Property(e => e.AdTimeChg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeChg");
            entity.Property(e => e.AdTimeIns)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeIns");
            entity.Property(e => e.AnAllowedInvShort)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("anAllowedInvShort");
            entity.Property(e => e.AnAllowedWastage)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("anAllowedWastage");
            entity.Property(e => e.AnBeatShare)
                .HasDefaultValue(1.0)
                .HasColumnName("anBeatShare");
            entity.Property(e => e.AnBuyPrice).HasColumnName("anBuyPrice");
            entity.Property(e => e.AnBuyRebate2)
                .HasDefaultValue(0.0)
                .HasColumnName("anBuyRebate2");
            entity.Property(e => e.AnBuyRebate3)
                .HasDefaultValue(0.0)
                .HasColumnName("anBuyRebate3");
            entity.Property(e => e.AnColorCode).HasColumnName("anColorCode");
            entity.Property(e => e.AnDeliveryDeadline).HasColumnName("anDeliveryDeadline");
            entity.Property(e => e.AnDimDepth)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDimDepth");
            entity.Property(e => e.AnDimHeight)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDimHeight");
            entity.Property(e => e.AnDimWeight)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDimWeight");
            entity.Property(e => e.AnDimWeightBrutto)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDimWeightBrutto");
            entity.Property(e => e.AnDimWidth)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDimWidth");
            entity.Property(e => e.AnDirectCost).HasColumnName("anDirectCost");
            entity.Property(e => e.AnDiscount)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("anDiscount");
            entity.Property(e => e.AnDiscountPrice)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDiscountPrice");
            entity.Property(e => e.AnDiscountPriceRt)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anDiscountPriceRT");
            entity.Property(e => e.AnDuty).HasColumnName("anDuty");
            entity.Property(e => e.AnExcise).HasColumnName("anExcise");
            entity.Property(e => e.AnExciseP).HasColumnName("anExciseP");
            entity.Property(e => e.AnFieldNa)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNA");
            entity.Property(e => e.AnFieldNb)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNB");
            entity.Property(e => e.AnFieldNc)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNC");
            entity.Property(e => e.AnFieldNd)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldND");
            entity.Property(e => e.AnFieldNe)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNE");
            entity.Property(e => e.AnFieldNf)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNF");
            entity.Property(e => e.AnFieldNg)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNG");
            entity.Property(e => e.AnFieldNh)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNH");
            entity.Property(e => e.AnFieldNi)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNI");
            entity.Property(e => e.AnFieldNj)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNJ");
            entity.Property(e => e.AnFixPriceDiff).HasColumnName("anFixPriceDiff");
            entity.Property(e => e.AnIncTax).HasColumnName("anIncTax");
            entity.Property(e => e.AnMaxRebate)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("anMaxRebate");
            entity.Property(e => e.AnMaxStock)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anMaxStock");
            entity.Property(e => e.AnMinMargin)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(6, 3)")
                .HasColumnName("anMinMargin");
            entity.Property(e => e.AnMinStock)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anMinStock");
            entity.Property(e => e.AnMnfilesQid).HasColumnName("anMNFilesQId");
            entity.Property(e => e.AnMonthDue)
                .HasDefaultValue(0)
                .HasColumnName("anMonthDue");
            entity.Property(e => e.AnNensi).HasColumnName("anNensi");
            entity.Property(e => e.AnOptStock)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anOptStock");
            entity.Property(e => e.AnOrderMinQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anOrderMinQty");
            entity.Property(e => e.AnOrderOptQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anOrderOptQty");
            entity.Property(e => e.AnPackWasteWeight)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPackWasteWeight");
            entity.Property(e => e.AnPackWeight)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPackWeight");
            entity.Property(e => e.AnPlucode).HasColumnName("anPLUCode");
            entity.Property(e => e.AnPlucode2).HasColumnName("anPLUCode2");
            entity.Property(e => e.AnPosQtyStep)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 4)")
                .HasColumnName("anPosQtyStep");
            entity.Property(e => e.AnPosqty)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPOSQty");
            entity.Property(e => e.AnPrStCheckUserId)
                .HasDefaultValue(0)
                .HasColumnName("anPrStCheckUserID");
            entity.Property(e => e.AnPrStDailyQty)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPrStDailyQty");
            entity.Property(e => e.AnPrStInsertUserId)
                .HasDefaultValue(0)
                .HasColumnName("anPrStInsertUserID");
            entity.Property(e => e.AnPrStOptimalQty)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anPrStOptimalQty");
            entity.Property(e => e.AnPrStPrice).HasColumnName("anPrStPrice");
            entity.Property(e => e.AnPrStPriceP).HasColumnName("anPrStPriceP");
            entity.Property(e => e.AnPrStUpdateUserId)
                .HasDefaultValue(0)
                .HasColumnName("anPrStUpdateUserID");
            entity.Property(e => e.AnPrStVariantValid).HasColumnName("anPrStVariantValid");
            entity.Property(e => e.AnPrice).HasColumnName("anPrice");
            entity.Property(e => e.AnPriceSupp).HasColumnName("anPriceSupp");
            entity.Property(e => e.AnProdPrice)
                .HasDefaultValue(0.0)
                .HasColumnName("anProdPrice");
            entity.Property(e => e.AnPrstTime)
                .HasDefaultValue(0.0)
                .HasColumnName("anPrstTime");
            entity.Property(e => e.AnPurExciseA).HasColumnName("anPurExciseA");
            entity.Property(e => e.AnPurExciseE).HasColumnName("anPurExciseE");
            entity.Property(e => e.AnPurExciseT).HasColumnName("anPurExciseT");
            entity.Property(e => e.AnQid)
                .ValueGeneratedOnAdd()
                .HasColumnName("anQId");
            entity.Property(e => e.AnQtyInCodeDecPlace).HasColumnName("anQtyInCodeDecPlace");
            entity.Property(e => e.AnQtyMarkLabel)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQtyMarkLabel");
            entity.Property(e => e.AnQtySeries)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anQtySeries");
            entity.Property(e => e.AnRebate).HasColumnName("anRebate");
            entity.Property(e => e.AnRtprice).HasColumnName("anRTPrice");
            entity.Property(e => e.AnRtpriceP).HasColumnName("anRTPriceP");
            entity.Property(e => e.AnSalePrice)
                .HasColumnType("money")
                .HasColumnName("anSalePrice");
            entity.Property(e => e.AnSaleRebate2)
                .HasDefaultValue(0.0)
                .HasColumnName("anSaleRebate2");
            entity.Property(e => e.AnSaleRebate3)
                .HasDefaultValue(0.0)
                .HasColumnName("anSaleRebate3");
            entity.Property(e => e.AnSubClassif).HasColumnName("anSubClassif");
            entity.Property(e => e.AnTransport).HasColumnName("anTransport");
            entity.Property(e => e.AnUmtoDeclarReport)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anUMToDeclarReport");
            entity.Property(e => e.AnUmtoUm2)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anUMToUM2");
            entity.Property(e => e.AnUmtoUm3)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anUMToUM3");
            entity.Property(e => e.AnUnionDeadline).HasColumnName("anUnionDeadline");
            entity.Property(e => e.AnUserChg)
                .HasDefaultValue(0)
                .HasColumnName("anUserChg");
            entity.Property(e => e.AnUserIns)
                .HasDefaultValue(0)
                .HasColumnName("anUserIns");
            entity.Property(e => e.AnVat)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("anVAT");
            entity.Property(e => e.AnVatreceive)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("anVATReceive");
            entity.Property(e => e.AnWarrenty).HasColumnName("anWarrenty");
            entity.Property(e => e.AnWasteQty)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anWasteQty");
            entity.Property(e => e.AnWsprice).HasColumnName("anWSPrice");
            entity.Property(e => e.AnWsprice2).HasColumnName("anWSPrice2");
            entity.Property(e => e.AnWsprice2P).HasColumnName("anWSPrice2P");
            entity.Property(e => e.AnWspriceP).HasColumnName("anWSPriceP");

            entity.HasOne(d => d.AcDeptNavigation).WithMany(p => p.THeSetItemAcDeptNavigations)
                .HasForeignKey(d => d.AcDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetItem_tHE_SetSubj_18");

            entity.HasOne(d => d.AcDroesubjectNavigation).WithMany(p => p.THeSetItemAcDroesubjectNavigations)
                .HasForeignKey(d => d.AcDroesubject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetItem_tHE_SetSubj_43");

            entity.HasOne(d => d.AcForSubjectNavigation).WithMany(p => p.THeSetItemAcForSubjectNavigations)
                .HasForeignKey(d => d.AcForSubject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetItem_tHE_SetSubj_41");

            entity.HasOne(d => d.AcSupplierNavigation).WithMany(p => p.THeSetItemAcSupplierNavigations)
                .HasForeignKey(d => d.AcSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetItem_tHE_SetSubj_4");
        });

        modelBuilder.Entity<THeSetSubj>(entity =>
        {
            entity.HasKey(e => e.AcSubject).HasName("kHE_SetSubj_0");

            entity.ToTable("tHE_SetSubj", tb =>
                {
                    tb.HasTrigger("gHE_SetSubjDepartment_security_update");
                    tb.HasTrigger("gHE_SetSubjDeptHier_insert");
                    tb.HasTrigger("gHE_SetSubjDeptHier_update");
                    tb.HasTrigger("gHE_SetSubjInsUD");
                    tb.HasTrigger("gHE_SetSubjUpdUD");
                    tb.HasTrigger("gHE_SetSubjWarehouse_security_update");
                    tb.HasTrigger("gHE_SetSubj_department_warehouse_security");
                    tb.HasTrigger("gHE_SetSubj_vatid");
                    tb.HasTrigger("gHE_TrackSubjPrimaryKeyChanges");
                    tb.HasTrigger("gHE_TrackSubjPrimaryKeyDeletes");
                    tb.HasTrigger("gPA_OnDelete_tHE_SetSubj");
                    tb.HasTrigger("gPA_tHE_SetSubj_UC");
                    tb.HasTrigger("gPA_tHE_SetSubj_UC_Exception");
                });

            entity.HasIndex(e => e.AcAcctClaim, "IX_SetSubj_tDE_SetAccountCo183");

            entity.HasIndex(e => e.AcAcctOblig, "IX_SetSubj_tDE_SetAccountCo184");

            entity.HasIndex(e => e.AcMunicipCreditor, "IX_SetSubj_tHE_SetSubj_3073");

            entity.HasIndex(e => e.AcXmldocType, "IX_tHE_SetSubj_38").HasFillFactor(75);

            entity.HasIndex(e => e.AnQid, "IX_tHE_SetSubj_Id")
                .IsUnique()
                .HasFillFactor(75);

            entity.HasIndex(e => new { e.AcWarehouse, e.AcStockManage }, "IX_tHE_SetSubj_Warehouse").HasFillFactor(75);

            entity.HasIndex(e => new { e.AcDept, e.AcSubject }, "iHE_SetSubj_Dept").HasFillFactor(75);

            entity.HasIndex(e => e.AcMunicipCode, "iHE_SetSubj_MunicipCode").HasFillFactor(75);

            entity.HasIndex(e => new { e.AcPayer, e.AcSubject }, "iHE_SetSubj_Payer");

            entity.HasIndex(e => new { e.AcStockManage, e.AcDispDoc, e.AcStockValue, e.AcStockRetailValue, e.AcSubject }, "iHE_SetSubj_StockManageName").HasFillFactor(75);

            entity.HasIndex(e => e.AnClerk, "idx_tHE_SetSubj_11");

            entity.HasIndex(e => e.AcCurrency, "idx_tHE_SetSubj_12");

            entity.HasIndex(e => e.AcPayMethod, "idx_tHE_SetSubj_13");

            entity.HasIndex(e => e.AcDelivery, "idx_tHE_SetSubj_14");

            entity.HasIndex(e => e.AcActivityCode, "idx_tHE_SetSubj_15");

            entity.HasIndex(e => e.AcSetOfInterestRates, "idx_tHE_SetSubj_21");

            entity.HasIndex(e => e.AcParity, "idx_tHE_SetSubj_22");

            entity.HasIndex(e => e.AcParityPost, "idx_tHE_SetSubj_23");

            entity.HasIndex(e => e.AcSkis, "idx_tHE_SetSubj_26");

            entity.HasIndex(e => e.AcVatcodePrefix, "idx_tHE_SetSubj_27");

            entity.HasIndex(e => e.AcPayLoc, "idx_tHE_SetSubj_32");

            entity.HasIndex(e => e.AcPost, "idx_tHE_SetSubj_6");

            entity.HasIndex(e => e.AcCountry, "idx_tHE_SetSubj_7");

            entity.HasIndex(e => e.AcStatement, "idx_tHE_SetSubj_8").HasFillFactor(75);

            entity.HasIndex(e => e.AcDeptMuni, "ix_FK_acDeptMuni");

            entity.HasIndex(e => e.AcPerInv, "ix_FK_acPerInv");

            entity.HasIndex(e => e.AcSubjTypeBuyer, "ix_FK_acSubjTypeBuyer");

            entity.HasIndex(e => e.AcSubjTypeSupp, "ix_FK_acSubjTypeSupp");

            entity.HasIndex(e => e.AcSuppCurr, "ix_FK_acSuppCurr");

            entity.HasIndex(e => e.AcSuppDelivery, "ix_FK_acSuppDelivery");

            entity.HasIndex(e => e.AcSuppParity, "ix_FK_acSuppParity");

            entity.HasIndex(e => e.AcSuppParityPost, "ix_FK_acSuppParityPost");

            entity.HasIndex(e => e.AcSuppPayMet, "ix_FK_acSuppPayMet");

            entity.HasIndex(e => e.AcSuppPerInv, "ix_FK_acSuppPerInv");

            entity.HasIndex(e => e.AcSuppStatement, "ix_FK_acSuppStatement");

            entity.HasIndex(e => e.AcSuprCommune, "ix_FK_acSuprCommune");

            entity.HasIndex(e => e.AcSuprDept, "ix_FK_acSuprDept");

            entity.HasIndex(e => e.AnSuppClerk, "ix_FK_anSuppClerk");

            entity.HasIndex(e => e.AcBankCode, "ix_tHE_SetSubj_BankCode");

            entity.HasIndex(e => e.AcPayer, "ix_tHE_SetSubj_Payer");

            entity.HasIndex(e => e.AnDeliveryPriority, "ix_tHE_SetSubj_Priority");

            entity.HasIndex(e => e.AcName2, "ix_the_setsubj_name_alternative").HasFillFactor(75);

            entity.HasIndex(e => e.AcPin, "ix_the_setsubj_pin").HasFillFactor(75);

            entity.Property(e => e.AcSubject)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSubject");
            entity.Property(e => e.AbPriceRatePos).HasColumnName("abPriceRatePos");
            entity.Property(e => e.AcAccountingPeriod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("D")
                .IsFixedLength()
                .HasColumnName("acAccountingPeriod");
            entity.Property(e => e.AcAcctClaim)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctClaim");
            entity.Property(e => e.AcAcctExpense)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("acAcctExpense");
            entity.Property(e => e.AcAcctGlopen)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctGLOpen");
            entity.Property(e => e.AcAcctIncome)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("acAcctIncome");
            entity.Property(e => e.AcAcctOblig)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAcctOblig");
            entity.Property(e => e.AcAcctRebateExtra)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("acAcctRebateExtra");
            entity.Property(e => e.AcActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acActive");
            entity.Property(e => e.AcActiveContacts)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acActiveContacts");
            entity.Property(e => e.AcActivityCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acActivityCode");
            entity.Property(e => e.AcAddress)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acAddress");
            entity.Property(e => e.AcAssortment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acAssortment");
            entity.Property(e => e.AcAtwarehouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acATWarehouse");
            entity.Property(e => e.AcBank)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acBank");
            entity.Property(e => e.AcBankCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acBankCode");
            entity.Property(e => e.AcBranch)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acBranch");
            entity.Property(e => e.AcBranchForm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acBranchForm");
            entity.Property(e => e.AcBudgetUser)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acBudgetUser");
            entity.Property(e => e.AcBuyer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acBuyer");
            entity.Property(e => e.AcBuyerCalcInvoOutFallDue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acBuyerCalcInvoOutFallDue");
            entity.Property(e => e.AcBuyerLimitCtrl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acBuyerLimitCtrl");
            entity.Property(e => e.AcCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCode");
            entity.Property(e => e.AcConsignee)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acConsignee");
            entity.Property(e => e.AcCostDrv)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCostDrv");
            entity.Property(e => e.AcCountry)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCountry");
            entity.Property(e => e.AcCreatePayOrd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acCreatePayOrd");
            entity.Property(e => e.AcCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acCurrency");
            entity.Property(e => e.AcDelivery)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDelivery");
            entity.Property(e => e.AcDept)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acDept");
            entity.Property(e => e.AcDeptMuni)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDeptMuni");
            entity.Property(e => e.AcDeptRegNo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acDeptRegNo");
            entity.Property(e => e.AcDispDoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acDispDoc");
            entity.Property(e => e.AcDontSendReminders)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acDontSendReminders");
            entity.Property(e => e.AcEslogContractCt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acEslogContractCT");
            entity.Property(e => e.AcExciseNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acExciseNumber");
            entity.Property(e => e.AcFarmerNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFarmerNo");
            entity.Property(e => e.AcFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acFax");
            entity.Property(e => e.AcFieldSa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSA");
            entity.Property(e => e.AcFieldSb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSB");
            entity.Property(e => e.AcFieldSc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSC");
            entity.Property(e => e.AcFieldSd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSD");
            entity.Property(e => e.AcFieldSe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSE");
            entity.Property(e => e.AcFieldSf)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSF");
            entity.Property(e => e.AcFieldSg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSG");
            entity.Property(e => e.AcFieldSh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSH");
            entity.Property(e => e.AcFieldSi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSI");
            entity.Property(e => e.AcFieldSj)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acFieldSJ");
            entity.Property(e => e.AcFiscalNo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acFiscalNo");
            entity.Property(e => e.AcFreeStockReport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acFreeStockReport");
            entity.Property(e => e.AcGln)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acGLN");
            entity.Property(e => e.AcHttppath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acHTTPPath");
            entity.Property(e => e.AcIbanprefix)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acIBANprefix");
            entity.Property(e => e.AcIdentList)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acIdentList");
            entity.Property(e => e.AcInstitution)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acInstitution");
            entity.Property(e => e.AcIntrstsBuyer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acIntrstsBuyer");
            entity.Property(e => e.AcIntrstsSupplier)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acIntrstsSupplier");
            entity.Property(e => e.AcJbkjs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acJBKJS");
            entity.Property(e => e.AcJibcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acJIBCode");
            entity.Property(e => e.AcLei)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acLEI");
            entity.Property(e => e.AcLocComm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acLocComm");
            entity.Property(e => e.AcLoyaltyPrefix)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acLoyaltyPrefix");
            entity.Property(e => e.AcMunicipCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acMunicipCode");
            entity.Property(e => e.AcMunicipCreditor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acMunicipCreditor");
            entity.Property(e => e.AcMunicipality)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acMunicipality");
            entity.Property(e => e.AcName2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acName2");
            entity.Property(e => e.AcName3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acName3");
            entity.Property(e => e.AcNaturalPerson)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acNaturalPerson");
            entity.Property(e => e.AcNcc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acNCC");
            entity.Property(e => e.AcNoExciseCalc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acNoExciseCalc");
            entity.Property(e => e.AcNote)
                .IsUnicode(false)
                .HasColumnName("acNote");
            entity.Property(e => e.AcOrgUnit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acOrgUnit");
            entity.Property(e => e.AcPac)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acPAC");
            entity.Property(e => e.AcParity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acParity");
            entity.Property(e => e.AcParityPost)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acParityPost");
            entity.Property(e => e.AcParityType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acParityType");
            entity.Property(e => e.AcPayLoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acPayLoc");
            entity.Property(e => e.AcPayMethod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayMethod");
            entity.Property(e => e.AcPayOrdPriorty)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("9")
                .IsFixedLength()
                .HasColumnName("acPayOrdPriorty");
            entity.Property(e => e.AcPayer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayer");
            entity.Property(e => e.AcPayerS)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPayerS");
            entity.Property(e => e.AcPerInv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPerInv");
            entity.Property(e => e.AcPermitLumpCompen)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("acPermitLumpCompen");
            entity.Property(e => e.AcPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acPhone");
            entity.Property(e => e.AcPin)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("acPIN");
            entity.Property(e => e.AcPincodePrefix)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPINCodePrefix");
            entity.Property(e => e.AcPost)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acPost");
            entity.Property(e => e.AcPriceCalcForItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acPriceCalcForItem");
            entity.Property(e => e.AcPriceCalcMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("acPriceCalcMethod");
            entity.Property(e => e.AcPriceRate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .IsFixedLength()
                .HasColumnName("acPriceRate");
            entity.Property(e => e.AcRegNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRegNo");
            entity.Property(e => e.AcRegion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acRegion");
            entity.Property(e => e.AcRemindersSendType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength()
                .HasColumnName("acRemindersSendType");
            entity.Property(e => e.AcRetail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acRetail");
            entity.Property(e => e.AcRotationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acRotationNumber");
            entity.Property(e => e.AcRsbainDistrikt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("K")
                .IsFixedLength()
                .HasColumnName("acRSBAInDistrikt");
            entity.Property(e => e.AcRsbainDistriktBuyer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("K")
                .IsFixedLength()
                .HasColumnName("acRSBAInDistriktBuyer");
            entity.Property(e => e.AcSchool)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acSchool");
            entity.Property(e => e.AcSeparSaleCalc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acSeparSaleCalc");
            entity.Property(e => e.AcSetOfInterestRates)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSetOfInterestRates");
            entity.Property(e => e.AcSkis)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSKIS");
            entity.Property(e => e.AcSkis2)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSKIS2");
            entity.Property(e => e.AcStatement)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acStatement");
            entity.Property(e => e.AcStockInMinus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acStockInMinus");
            entity.Property(e => e.AcStockManage)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("acStockManage");
            entity.Property(e => e.AcStockRetailValue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("acStockRetailValue");
            entity.Property(e => e.AcStockValue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("acStockValue");
            entity.Property(e => e.AcSubUnit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acSubUnit");
            entity.Property(e => e.AcSubUnitCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acSubUnitCode");
            entity.Property(e => e.AcSubUnitRegNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("acSubUnitRegNo");
            entity.Property(e => e.AcSubUnitTaxCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSubUnitTaxCode");
            entity.Property(e => e.AcSubjTypeBuyer)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSubjTypeBuyer");
            entity.Property(e => e.AcSubjTypeSupp)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSubjTypeSupp");
            entity.Property(e => e.AcSuppCurr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppCurr");
            entity.Property(e => e.AcSuppDelivery)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppDelivery");
            entity.Property(e => e.AcSuppParity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppParity");
            entity.Property(e => e.AcSuppParityPost)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppParityPost");
            entity.Property(e => e.AcSuppParityType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acSuppParityType");
            entity.Property(e => e.AcSuppPayMet)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppPayMet");
            entity.Property(e => e.AcSuppPerInv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppPerInv");
            entity.Property(e => e.AcSuppPriceCalcMet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("acSuppPriceCalcMet");
            entity.Property(e => e.AcSuppSaleMet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("D")
                .IsFixedLength()
                .HasColumnName("acSuppSaleMet");
            entity.Property(e => e.AcSuppStatement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuppStatement");
            entity.Property(e => e.AcSuppYearStatement)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acSuppYearStatement");
            entity.Property(e => e.AcSupplier)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("T")
                .IsFixedLength()
                .HasColumnName("acSupplier");
            entity.Property(e => e.AcSuprCommune)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuprCommune");
            entity.Property(e => e.AcSuprDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acSuprDept");
            entity.Property(e => e.AcSwiftcode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acSWIFTCode");
            entity.Property(e => e.AcUser)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acUser");
            entity.Property(e => e.AcVatcodePrefix)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acVATCodePrefix");
            entity.Property(e => e.AcVatpayRealSupp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acVATPayRealSupp");
            entity.Property(e => e.AcVeterinarian)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acVeterinarian");
            entity.Property(e => e.AcWarehouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWarehouse");
            entity.Property(e => e.AcWarehouseCapacityUm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acWarehouseCapacityUM");
            entity.Property(e => e.AcWarehouseStockNotInQty)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWarehouseStockNotInQty");
            entity.Property(e => e.AcWayOfSale)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Z")
                .IsFixedLength()
                .HasColumnName("acWayOfSale");
            entity.Property(e => e.AcWebShopSubject)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWebShopSubject");
            entity.Property(e => e.AcWorker)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acWorker");
            entity.Property(e => e.AcXmldocCript)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acXMLDocCript");
            entity.Property(e => e.AcXmldocSign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("F")
                .IsFixedLength()
                .HasColumnName("acXMLDocSign");
            entity.Property(e => e.AcXmldocType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("K")
                .IsFixedLength()
                .HasColumnName("acXMLDocType");
            entity.Property(e => e.AcXmlglnno)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("acXMLGLNNo");
            entity.Property(e => e.AcYearStatement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("acYearStatement");
            entity.Property(e => e.AceSlogVer)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("1.6")
                .IsFixedLength()
                .HasColumnName("aceSlogVer");
            entity.Property(e => e.AdAnafcheckDate)
                .HasColumnType("datetime")
                .HasColumnName("adANAFCheckDate");
            entity.Property(e => e.AdDateInvent)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateInvent");
            entity.Property(e => e.AdDateLimit)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateLimit");
            entity.Property(e => e.AdDateState)
                .HasColumnType("smalldatetime")
                .HasColumnName("adDateState");
            entity.Property(e => e.AdFieldDa)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDA");
            entity.Property(e => e.AdFieldDb)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDB");
            entity.Property(e => e.AdFieldDc)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDC");
            entity.Property(e => e.AdFieldDd)
                .HasColumnType("datetime")
                .HasColumnName("adFieldDD");
            entity.Property(e => e.AdSuppDateLim)
                .HasColumnType("smalldatetime")
                .HasColumnName("adSuppDateLim");
            entity.Property(e => e.AdSuppDateSta)
                .HasColumnType("smalldatetime")
                .HasColumnName("adSuppDateSta");
            entity.Property(e => e.AdTimeChg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeChg");
            entity.Property(e => e.AdTimeIns)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("adTimeIns");
            entity.Property(e => e.AnAllowedInvShort)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("anAllowedInvShort");
            entity.Property(e => e.AnClerk).HasColumnName("anClerk");
            entity.Property(e => e.AnContactPrsnB)
                .HasDefaultValue(0)
                .HasColumnName("anContactPrsnB");
            entity.Property(e => e.AnContactPrsnS)
                .HasDefaultValue(0)
                .HasColumnName("anContactPrsnS");
            entity.Property(e => e.AnDaysForPayment).HasColumnName("anDaysForPayment");
            entity.Property(e => e.AnDeliveryDays)
                .HasDefaultValue((short)0)
                .HasColumnName("anDeliveryDays");
            entity.Property(e => e.AnDeliveryPriority).HasColumnName("anDeliveryPriority");
            entity.Property(e => e.AnFieldNa)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNA");
            entity.Property(e => e.AnFieldNb)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNB");
            entity.Property(e => e.AnFieldNc)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNC");
            entity.Property(e => e.AnFieldNd)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldND");
            entity.Property(e => e.AnFieldNe)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNE");
            entity.Property(e => e.AnFieldNf)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNF");
            entity.Property(e => e.AnFieldNg)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNG");
            entity.Property(e => e.AnFieldNh)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNH");
            entity.Property(e => e.AnFieldNi)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNI");
            entity.Property(e => e.AnFieldNj)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anFieldNJ");
            entity.Property(e => e.AnInstalmentNo)
                .HasDefaultValue(-1)
                .HasColumnName("anInstalmentNo");
            entity.Property(e => e.AnKm).HasColumnName("anKm");
            entity.Property(e => e.AnLatitude)
                .HasColumnType("decimal(19, 14)")
                .HasColumnName("anLatitude");
            entity.Property(e => e.AnLimit)
                .HasColumnType("money")
                .HasColumnName("anLimit");
            entity.Property(e => e.AnLongitude)
                .HasColumnType("decimal(19, 14)")
                .HasColumnName("anLongitude");
            entity.Property(e => e.AnMaxDaysPayDelay)
                .HasDefaultValue(0)
                .HasColumnName("anMaxDaysPayDelay");
            entity.Property(e => e.AnMaxRebate)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("anMaxRebate");
            entity.Property(e => e.AnMinMargin)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("anMinMargin");
            entity.Property(e => e.AnOrderValidBuyer)
                .HasDefaultValue(-1)
                .HasColumnName("anOrderValidBuyer");
            entity.Property(e => e.AnOrderValidSupplier)
                .HasDefaultValue(-1)
                .HasColumnName("anOrderValidSupplier");
            entity.Property(e => e.AnOrgColor).HasColumnName("anOrgColor");
            entity.Property(e => e.AnQid)
                .ValueGeneratedOnAdd()
                .HasColumnName("anQId");
            entity.Property(e => e.AnRebate)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("anRebate");
            entity.Property(e => e.AnSubjVar1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar1");
            entity.Property(e => e.AnSubjVar10)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar10");
            entity.Property(e => e.AnSubjVar2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar2");
            entity.Property(e => e.AnSubjVar3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar3");
            entity.Property(e => e.AnSubjVar4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar4");
            entity.Property(e => e.AnSubjVar5)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar5");
            entity.Property(e => e.AnSubjVar6)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar6");
            entity.Property(e => e.AnSubjVar7)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar7");
            entity.Property(e => e.AnSubjVar8)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar8");
            entity.Property(e => e.AnSubjVar9)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSubjVar9");
            entity.Property(e => e.AnSuppClerk).HasColumnName("anSuppClerk");
            entity.Property(e => e.AnSuppDiscount)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("anSuppDiscount");
            entity.Property(e => e.AnSuppInstalmentNo)
                .HasDefaultValue(-1)
                .HasColumnName("anSuppInstalmentNo");
            entity.Property(e => e.AnSuppLimit)
                .HasColumnType("money")
                .HasColumnName("anSuppLimit");
            entity.Property(e => e.AnSuppPayDays).HasColumnName("anSuppPayDays");
            entity.Property(e => e.AnUserChg)
                .HasDefaultValue(0)
                .HasColumnName("anUserChg");
            entity.Property(e => e.AnUserIns)
                .HasDefaultValue(0)
                .HasColumnName("anUserIns");
            entity.Property(e => e.AnWarehouseCapacity)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("anWarehouseCapacity");
            entity.Property(e => e.AnWorkingDaysInWeek)
                .HasDefaultValue(0)
                .HasColumnName("anWorkingDaysInWeek");
            entity.Property(e => e.AnWorkingHours)
                .HasDefaultValue(0)
                .HasColumnName("anWorkingHours");

            entity.HasOne(d => d.AcDeptMuniNavigation).WithMany(p => p.InverseAcDeptMuniNavigation)
                .HasForeignKey(d => d.AcDeptMuni)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetSubj_tHE_SetSubj_29");

            entity.HasOne(d => d.AcMunicipCreditorNavigation).WithMany(p => p.InverseAcMunicipCreditorNavigation)
                .HasForeignKey(d => d.AcMunicipCreditor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetSubj_tHE_SetSubj_30");

            entity.HasOne(d => d.AcPayerNavigation).WithMany(p => p.InverseAcPayerNavigation)
                .HasForeignKey(d => d.AcPayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetSubj_tHE_SetSubj_10");

            entity.HasOne(d => d.AcPayerSNavigation).WithMany(p => p.InverseAcPayerSNavigation)
                .HasForeignKey(d => d.AcPayerS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetSubj_tHE_SetSubj_38");

            entity.HasOne(d => d.AcSuprCommuneNavigation).WithMany(p => p.InverseAcSuprCommuneNavigation)
                .HasForeignKey(d => d.AcSuprCommune)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetSubj_tHE_SetSubj_24");

            entity.HasOne(d => d.AcSuprDeptNavigation).WithMany(p => p.InverseAcSuprDeptNavigation)
                .HasForeignKey(d => d.AcSuprDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rtHE_SetSubj_tHE_SetSubj_25");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
