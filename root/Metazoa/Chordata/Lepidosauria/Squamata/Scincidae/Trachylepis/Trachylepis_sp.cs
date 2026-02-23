namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis;

/// <summary>
/// Species: Trachylepis sp.
/// NCBI TaxId: 2926946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachylepis_sp : Trachylepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachylepis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachylepis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2926946;
}
