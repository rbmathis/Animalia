namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

/// <summary>
/// Species: Hyperolius quinquevittatus
/// NCBI TaxId: 1277655
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyperolius_quinquevittatus : Hyperolius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyperolius quinquevittatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyperolius_quinquevittatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1277655;
}
