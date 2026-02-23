namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Trogon;

/// <summary>
/// Species: Trogon violaceus
/// NCBI TaxId: 59418
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trogon_violaceus : Trogon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trogon violaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trogon_violaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59418;
}
