namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Dendroaspis;

/// <summary>
/// Species: Dendroaspis polylepis
/// NCBI TaxId: 8624
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendroaspis_polylepis : Dendroaspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendroaspis polylepis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendroaspis_polylepis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8624;
}
