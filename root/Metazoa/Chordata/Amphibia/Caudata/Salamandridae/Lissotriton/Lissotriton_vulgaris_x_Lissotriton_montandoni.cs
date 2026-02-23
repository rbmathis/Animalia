namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Lissotriton;

/// <summary>
/// Species: Lissotriton vulgaris x Lissotriton montandoni
/// NCBI TaxId: 323758
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lissotriton_vulgaris_x_Lissotriton_montandoni : Lissotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lissotriton vulgaris x Lissotriton montandoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lissotriton_vulgaris_x_Lissotriton_montandoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323758;
}
