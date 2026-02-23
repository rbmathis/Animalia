namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Amphiglossus;

/// <summary>
/// Species: Amphiglossus sp. MMB-2003
/// NCBI TaxId: 249533
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphiglossus_sp_MMB_2003 : Amphiglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphiglossus sp. MMB-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphiglossus_sp_MMB_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 249533;
}
