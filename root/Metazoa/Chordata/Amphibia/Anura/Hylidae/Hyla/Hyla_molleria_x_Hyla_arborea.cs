namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla molleria x Hyla arborea
/// NCBI TaxId: 1200299
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_molleria_x_Hyla_arborea : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla molleria x Hyla arborea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_molleria_x_Hyla_arborea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1200299;
}
