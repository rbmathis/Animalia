namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis brasiliensis
/// NCBI TaxId: 1184710
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_brasiliensis : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis brasiliensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_brasiliensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1184710;
}
