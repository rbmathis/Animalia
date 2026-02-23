namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ailuridae.Ailurus;

/// <summary>
/// Species: Ailurus fulgens
/// NCBI TaxId: 9649
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ailurus_fulgens : Ailurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ailurus fulgens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ailurus_fulgens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9649;
}
