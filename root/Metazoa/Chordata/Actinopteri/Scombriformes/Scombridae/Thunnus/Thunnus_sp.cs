namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnus;

/// <summary>
/// Species: Thunnus sp.
/// NCBI TaxId: 8239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thunnus_sp : Thunnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thunnus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thunnus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8239;
}
