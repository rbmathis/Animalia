namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Leptonycteris;

/// <summary>
/// Species: Leptonycteris curasoae
/// NCBI TaxId: 55054
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptonycteris_curasoae : Leptonycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptonycteris curasoae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptonycteris_curasoae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55054;
}
