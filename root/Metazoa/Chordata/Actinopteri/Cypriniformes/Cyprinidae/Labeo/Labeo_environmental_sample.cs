namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeo;

/// <summary>
/// Species: Labeo environmental sample
/// NCBI TaxId: 3239017
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Labeo_environmental_sample : Labeo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Labeo environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Labeo_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3239017;
}
