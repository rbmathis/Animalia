namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eurylepis;

/// <summary>
/// Species: Eurylepis taeniolata
/// NCBI TaxId: 273653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eurylepis_taeniolata : Eurylepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eurylepis taeniolata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eurylepis_taeniolata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 273653;
}
