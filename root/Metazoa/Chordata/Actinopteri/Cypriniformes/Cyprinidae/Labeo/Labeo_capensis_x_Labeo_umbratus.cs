namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeo;

/// <summary>
/// Species: Labeo capensis x Labeo umbratus
/// NCBI TaxId: 2135815
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Labeo_capensis_x_Labeo_umbratus : Labeo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Labeo capensis x Labeo umbratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Labeo_capensis_x_Labeo_umbratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2135815;
}
