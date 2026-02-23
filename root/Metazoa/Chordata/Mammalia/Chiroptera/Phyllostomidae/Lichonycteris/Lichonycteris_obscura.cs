namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lichonycteris;

/// <summary>
/// Species: Lichonycteris obscura
/// NCBI TaxId: 1001577
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lichonycteris_obscura : Lichonycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lichonycteris obscura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lichonycteris_obscura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1001577;
}
