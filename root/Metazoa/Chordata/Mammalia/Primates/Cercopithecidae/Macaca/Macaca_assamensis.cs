namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca assamensis
/// NCBI TaxId: 9551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_assamensis : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca assamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_assamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9551;
}
