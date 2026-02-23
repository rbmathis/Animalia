namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Leptonycteris;

/// <summary>
/// Species: Leptonycteris nivalis
/// NCBI TaxId: 59456
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptonycteris_nivalis : Leptonycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptonycteris nivalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptonycteris_nivalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59456;
}
