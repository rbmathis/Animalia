namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Dendroaspis;

/// <summary>
/// Species: Dendroaspis viridis
/// NCBI TaxId: 8621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendroaspis_viridis : Dendroaspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendroaspis viridis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendroaspis_viridis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8621;
}
