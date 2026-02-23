namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis;

/// <summary>
/// Species: Didelphis pernigra
/// NCBI TaxId: 994805
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Didelphis_pernigra : Didelphis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Didelphis pernigra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Didelphis_pernigra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 994805;
}
