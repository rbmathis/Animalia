namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae.Palaeopropithecus;

/// <summary>
/// Species: Palaeopropithecus ingens
/// NCBI TaxId: 1513477
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Palaeopropithecus_ingens : Palaeopropithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Palaeopropithecus ingens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Palaeopropithecus_ingens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1513477;
}
