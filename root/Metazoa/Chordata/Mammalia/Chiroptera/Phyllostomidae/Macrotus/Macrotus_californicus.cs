namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Macrotus;

/// <summary>
/// Species: Macrotus californicus
/// NCBI TaxId: 9419
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrotus_californicus : Macrotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrotus californicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrotus_californicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9419;
}
