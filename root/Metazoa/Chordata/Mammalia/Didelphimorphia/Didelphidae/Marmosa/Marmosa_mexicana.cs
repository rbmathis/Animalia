namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa;

/// <summary>
/// Species: Marmosa mexicana
/// NCBI TaxId: 225402
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmosa_mexicana : Marmosa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmosa mexicana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmosa_mexicana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 225402;
}
