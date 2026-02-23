namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomber;

/// <summary>
/// Species: Scomber sp. TY
/// NCBI TaxId: 1523038
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scomber_sp_TY : Scomber
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scomber sp. TY";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scomber_sp_TY";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1523038;
}
