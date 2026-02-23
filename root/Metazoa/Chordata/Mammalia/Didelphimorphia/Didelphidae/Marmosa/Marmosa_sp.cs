namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa;

/// <summary>
/// Species: Marmosa sp.
/// NCBI TaxId: 3401256
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmosa_sp : Marmosa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmosa sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmosa_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3401256;
}
