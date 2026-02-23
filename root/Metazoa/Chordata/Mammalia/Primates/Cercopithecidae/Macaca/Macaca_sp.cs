namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca sp.
/// NCBI TaxId: 9549
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_sp : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9549;
}
