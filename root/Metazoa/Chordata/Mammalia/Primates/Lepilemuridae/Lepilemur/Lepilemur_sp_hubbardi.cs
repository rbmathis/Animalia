namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Lepilemur;

/// <summary>
/// Species: Lepilemur sp. hubbardi
/// NCBI TaxId: 400023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepilemur_sp_hubbardi : Lepilemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepilemur sp. hubbardi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepilemur_sp_hubbardi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 400023;
}
