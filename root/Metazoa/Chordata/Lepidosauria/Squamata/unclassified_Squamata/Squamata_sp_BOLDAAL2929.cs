namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Squamata;

/// <summary>
/// Species: Squamata sp. BOLD:AAL2929
/// NCBI TaxId: 854800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squamata_sp_BOLDAAL2929 : unclassified_Squamata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squamata sp. BOLD:AAL2929";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squamata_sp_BOLDAAL2929";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 854800;
}
