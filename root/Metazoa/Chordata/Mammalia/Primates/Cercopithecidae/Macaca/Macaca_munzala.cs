namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca munzala
/// NCBI TaxId: 402888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_munzala : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca munzala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_munzala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 402888;
}
