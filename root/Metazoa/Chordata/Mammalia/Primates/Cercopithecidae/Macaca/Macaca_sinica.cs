namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca sinica
/// NCBI TaxId: 9552
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_sinica : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca sinica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_sinica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9552;
}
