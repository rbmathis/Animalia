namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhabdophis;

/// <summary>
/// Species: Rhabdophis sp.
/// NCBI TaxId: 2795765
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhabdophis_sp : Rhabdophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhabdophis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhabdophis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2795765;
}
