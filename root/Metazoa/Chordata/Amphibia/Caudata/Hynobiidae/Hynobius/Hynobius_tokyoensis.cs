namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

/// <summary>
/// Species: Hynobius tokyoensis
/// NCBI TaxId: 324344
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hynobius_tokyoensis : Hynobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hynobius tokyoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hynobius_tokyoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 324344;
}
