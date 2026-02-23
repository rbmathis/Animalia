namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Microkayla;

/// <summary>
/// Species: Microkayla sp. Khatu River
/// NCBI TaxId: 2006967
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microkayla_sp_Khatu_River : Microkayla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microkayla sp. Khatu River";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microkayla_sp_Khatu_River";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2006967;
}
