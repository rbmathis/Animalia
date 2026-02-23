namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taterillus;

/// <summary>
/// Species: Taterillus harringtoni
/// NCBI TaxId: 3028010
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Taterillus_harringtoni : Taterillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Taterillus harringtoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Taterillus_harringtoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3028010;
}
