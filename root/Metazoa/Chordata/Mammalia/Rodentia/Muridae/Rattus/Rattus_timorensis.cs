namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus timorensis
/// NCBI TaxId: 2716769
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_timorensis : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus timorensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_timorensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2716769;
}
