namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnus;

/// <summary>
/// Species: Thunnus orientalis
/// NCBI TaxId: 8238
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thunnus_orientalis : Thunnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thunnus orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thunnus_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8238;
}
