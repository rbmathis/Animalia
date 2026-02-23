namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnus;

/// <summary>
/// Species: Thunnus atlanticus
/// NCBI TaxId: 48168
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thunnus_atlanticus : Thunnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thunnus atlanticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thunnus_atlanticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48168;
}
