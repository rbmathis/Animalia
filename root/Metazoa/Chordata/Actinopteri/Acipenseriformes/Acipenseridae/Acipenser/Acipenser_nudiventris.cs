namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser nudiventris
/// NCBI TaxId: 61967
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_nudiventris : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser nudiventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_nudiventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61967;
}
