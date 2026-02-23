namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis;

/// <summary>
/// Species: Trachylepis occidentalis
/// NCBI TaxId: 356597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachylepis_occidentalis : Trachylepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachylepis occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachylepis_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 356597;
}
