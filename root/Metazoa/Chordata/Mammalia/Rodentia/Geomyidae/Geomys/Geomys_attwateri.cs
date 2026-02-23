namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Species: Geomys attwateri
/// NCBI TaxId: 72447
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geomys_attwateri : Geomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geomys attwateri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geomys_attwateri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 72447;
}
