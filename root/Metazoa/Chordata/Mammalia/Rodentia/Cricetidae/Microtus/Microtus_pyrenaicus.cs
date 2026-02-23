namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus pyrenaicus
/// NCBI TaxId: 269654
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_pyrenaicus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus pyrenaicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_pyrenaicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 269654;
}
