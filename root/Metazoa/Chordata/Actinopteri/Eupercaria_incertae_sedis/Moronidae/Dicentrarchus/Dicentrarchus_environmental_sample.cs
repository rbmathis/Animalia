namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Moronidae.Dicentrarchus;

/// <summary>
/// Species: Dicentrarchus environmental sample
/// NCBI TaxId: 1814131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dicentrarchus_environmental_sample : Dicentrarchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dicentrarchus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dicentrarchus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814131;
}
