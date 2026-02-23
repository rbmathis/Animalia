namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Pampus;

/// <summary>
/// Species: Pampus sp. voucher NSJ
/// NCBI TaxId: 2794987
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pampus_sp_voucher_NSJ : Pampus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pampus sp. voucher NSJ";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pampus_sp_voucher_NSJ";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2794987;
}
