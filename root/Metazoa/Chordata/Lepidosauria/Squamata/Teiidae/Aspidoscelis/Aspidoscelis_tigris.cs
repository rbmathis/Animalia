namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

/// <summary>
/// Species: Aspidoscelis tigris
/// NCBI TaxId: 52180
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aspidoscelis_tigris : Aspidoscelis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aspidoscelis tigris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aspidoscelis_tigris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52180;
}
