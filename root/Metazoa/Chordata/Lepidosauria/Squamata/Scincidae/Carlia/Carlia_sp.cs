namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carlia;

/// <summary>
/// Species: Carlia sp.
/// NCBI TaxId: 1857312
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carlia_sp : Carlia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carlia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carlia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1857312;
}
