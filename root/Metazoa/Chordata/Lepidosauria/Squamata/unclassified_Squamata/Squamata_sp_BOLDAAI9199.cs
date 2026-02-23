namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Squamata;

/// <summary>
/// Species: Squamata sp. BOLD:AAI9199
/// NCBI TaxId: 854774
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squamata_sp_BOLDAAI9199 : unclassified_Squamata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squamata sp. BOLD:AAI9199";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squamata_sp_BOLDAAI9199";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 854774;
}
