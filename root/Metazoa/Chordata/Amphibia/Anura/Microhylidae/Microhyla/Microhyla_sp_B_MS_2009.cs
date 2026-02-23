namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla sp. B MS-2009
/// NCBI TaxId: 694490
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_sp_B_MS_2009 : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla sp. B MS-2009";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_sp_B_MS_2009";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 694490;
}
