namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Gelanesaurus;

/// <summary>
/// Species: Gelanesaurus flavogularis
/// NCBI TaxId: 1819705
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gelanesaurus_flavogularis : Gelanesaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gelanesaurus flavogularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gelanesaurus_flavogularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1819705;
}
