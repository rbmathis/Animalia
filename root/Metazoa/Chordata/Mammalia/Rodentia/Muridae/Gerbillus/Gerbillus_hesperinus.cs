namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillus;

/// <summary>
/// Species: Gerbillus hesperinus
/// NCBI TaxId: 1131342
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbillus_hesperinus : Gerbillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbillus hesperinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbillus_hesperinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1131342;
}
