namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Plagioscion;

/// <summary>
/// Species: Plagioscion surinamensis
/// NCBI TaxId: 1642198
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plagioscion_surinamensis : Plagioscion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plagioscion surinamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plagioscion_surinamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1642198;
}
