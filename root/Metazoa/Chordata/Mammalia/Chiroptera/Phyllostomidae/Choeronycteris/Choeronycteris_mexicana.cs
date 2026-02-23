namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Choeronycteris;

/// <summary>
/// Species: Choeronycteris mexicana
/// NCBI TaxId: 148050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Choeronycteris_mexicana : Choeronycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Choeronycteris mexicana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Choeronycteris_mexicana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148050;
}
