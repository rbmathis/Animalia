namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Squamata;

/// <summary>
/// Species: Squamata sp. BOLD:AAE1873
/// NCBI TaxId: 976709
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squamata_sp_BOLDAAE1873 : unclassified_Squamata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squamata sp. BOLD:AAE1873";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squamata_sp_BOLDAAE1873";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 976709;
}
