namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Laticauda;

/// <summary>
/// Species: Laticauda semifasciata
/// NCBI TaxId: 8631
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Laticauda_semifasciata : Laticauda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Laticauda semifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Laticauda_semifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8631;
}
