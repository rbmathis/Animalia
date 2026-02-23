namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis;

/// <summary>
/// Species: Didelphis sp.
/// NCBI TaxId: 30672
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Didelphis_sp : Didelphis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Didelphis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Didelphis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30672;
}
