namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Species: Phrynops geoffroanus
/// NCBI TaxId: 44502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynops_geoffroanus : Phrynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynops geoffroanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynops_geoffroanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44502;
}
