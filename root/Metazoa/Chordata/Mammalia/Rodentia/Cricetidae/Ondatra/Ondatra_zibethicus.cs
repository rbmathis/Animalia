namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ondatra;

/// <summary>
/// Species: Ondatra zibethicus
/// NCBI TaxId: 10060
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ondatra_zibethicus : Ondatra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ondatra zibethicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ondatra_zibethicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10060;
}
