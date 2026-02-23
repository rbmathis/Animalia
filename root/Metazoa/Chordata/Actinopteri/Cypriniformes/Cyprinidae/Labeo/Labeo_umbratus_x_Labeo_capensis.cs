namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeo;

/// <summary>
/// Species: Labeo umbratus x Labeo capensis
/// NCBI TaxId: 2135817
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Labeo_umbratus_x_Labeo_capensis : Labeo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Labeo umbratus x Labeo capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Labeo_umbratus_x_Labeo_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2135817;
}
