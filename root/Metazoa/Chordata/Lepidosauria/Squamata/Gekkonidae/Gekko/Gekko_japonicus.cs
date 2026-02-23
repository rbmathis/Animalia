namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko japonicus
/// NCBI TaxId: 146911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_japonicus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 146911;
}
