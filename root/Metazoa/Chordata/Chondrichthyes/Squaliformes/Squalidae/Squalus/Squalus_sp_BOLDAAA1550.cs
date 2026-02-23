namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus sp. BOLD:AAA1550
/// NCBI TaxId: 1004037
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_sp_BOLDAAA1550 : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus sp. BOLD:AAA1550";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_sp_BOLDAAA1550";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1004037;
}
