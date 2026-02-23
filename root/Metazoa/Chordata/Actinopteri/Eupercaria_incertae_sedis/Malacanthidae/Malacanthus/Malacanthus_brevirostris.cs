namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Malacanthus;

/// <summary>
/// Species: Malacanthus brevirostris
/// NCBI TaxId: 990986
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malacanthus_brevirostris : Malacanthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malacanthus brevirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malacanthus_brevirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 990986;
}
