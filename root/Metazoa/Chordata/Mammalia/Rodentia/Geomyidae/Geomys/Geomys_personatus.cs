namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Species: Geomys personatus
/// NCBI TaxId: 35659
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geomys_personatus : Geomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geomys personatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geomys_personatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 35659;
}
