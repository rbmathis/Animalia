namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnus;

/// <summary>
/// Species: Thunnus obesus
/// NCBI TaxId: 8241
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thunnus_obesus : Thunnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thunnus obesus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thunnus_obesus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8241;
}
