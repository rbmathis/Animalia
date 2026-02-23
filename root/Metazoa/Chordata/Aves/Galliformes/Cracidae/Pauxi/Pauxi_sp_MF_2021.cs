namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pauxi;

/// <summary>
/// Species: Pauxi sp. MF-2021
/// NCBI TaxId: 2866053
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pauxi_sp_MF_2021 : Pauxi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pauxi sp. MF-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pauxi_sp_MF_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2866053;
}
