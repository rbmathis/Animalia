namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Species: Geomys arenarius
/// NCBI TaxId: 108582
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geomys_arenarius : Geomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geomys arenarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geomys_arenarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 108582;
}
