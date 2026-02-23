namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Laticauda;

/// <summary>
/// Species: Laticauda laticaudata
/// NCBI TaxId: 8630
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Laticauda_laticaudata : Laticauda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Laticauda laticaudata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Laticauda_laticaudata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8630;
}
