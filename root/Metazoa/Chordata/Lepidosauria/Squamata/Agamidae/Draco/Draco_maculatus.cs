namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco maculatus
/// NCBI TaxId: 89026
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_maculatus : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89026;
}
