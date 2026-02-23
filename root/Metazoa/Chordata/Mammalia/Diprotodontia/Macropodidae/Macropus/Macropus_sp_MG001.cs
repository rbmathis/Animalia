namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Macropus;

/// <summary>
/// Species: Macropus sp. MG001
/// NCBI TaxId: 332475
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macropus_sp_MG001 : Macropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macropus sp. MG001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macropus_sp_MG001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332475;
}
