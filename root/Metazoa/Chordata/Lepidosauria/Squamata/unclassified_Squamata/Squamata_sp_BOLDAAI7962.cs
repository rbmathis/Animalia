namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Squamata;

/// <summary>
/// Species: Squamata sp. BOLD:AAI7962
/// NCBI TaxId: 854771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squamata_sp_BOLDAAI7962 : unclassified_Squamata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squamata sp. BOLD:AAI7962";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squamata_sp_BOLDAAI7962";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 854771;
}
