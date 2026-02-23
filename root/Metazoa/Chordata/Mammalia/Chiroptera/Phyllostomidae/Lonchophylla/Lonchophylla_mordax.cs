namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lonchophylla;

/// <summary>
/// Species: Lonchophylla mordax
/// NCBI TaxId: 190508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lonchophylla_mordax : Lonchophylla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lonchophylla mordax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lonchophylla_mordax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190508;
}
