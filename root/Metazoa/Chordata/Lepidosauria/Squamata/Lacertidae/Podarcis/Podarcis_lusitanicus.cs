namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Podarcis;

/// <summary>
/// Species: Podarcis lusitanicus
/// NCBI TaxId: 2060116
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podarcis_lusitanicus : Podarcis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podarcis lusitanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podarcis_lusitanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2060116;
}
