namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus townsendii
/// NCBI TaxId: 63225
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_townsendii : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus townsendii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_townsendii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 63225;
}
