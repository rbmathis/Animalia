namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Leiolepis;

/// <summary>
/// Species: Leiolepis boehmei
/// NCBI TaxId: 666331
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leiolepis_boehmei : Leiolepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leiolepis boehmei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leiolepis_boehmei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 666331;
}
