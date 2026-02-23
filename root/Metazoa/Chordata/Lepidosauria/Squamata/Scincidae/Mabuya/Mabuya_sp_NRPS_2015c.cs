namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mabuya;

/// <summary>
/// Species: Mabuya sp. NRPS-2015c
/// NCBI TaxId: 1620417
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mabuya_sp_NRPS_2015c : Mabuya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mabuya sp. NRPS-2015c";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mabuya_sp_NRPS_2015c";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1620417;
}
