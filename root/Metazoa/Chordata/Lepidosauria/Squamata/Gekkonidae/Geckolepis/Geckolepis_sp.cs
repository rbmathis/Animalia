namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Geckolepis;

/// <summary>
/// Species: Geckolepis sp.
/// NCBI TaxId: 2358256
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geckolepis_sp : Geckolepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geckolepis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geckolepis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2358256;
}
