namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eutropis;

/// <summary>
/// Species: Eutropis multifasciata
/// NCBI TaxId: 217868
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eutropis_multifasciata : Eutropis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eutropis multifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eutropis_multifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 217868;
}
