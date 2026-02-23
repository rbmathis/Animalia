namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Macrophyllum;

/// <summary>
/// Species: Macrophyllum macrophyllum
/// NCBI TaxId: 148062
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrophyllum_macrophyllum : Macrophyllum
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrophyllum macrophyllum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrophyllum_macrophyllum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148062;
}
