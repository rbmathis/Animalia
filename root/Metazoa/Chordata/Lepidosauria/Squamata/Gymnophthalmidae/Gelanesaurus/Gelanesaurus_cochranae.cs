namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Gelanesaurus;

/// <summary>
/// Species: Gelanesaurus cochranae
/// NCBI TaxId: 1819695
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gelanesaurus_cochranae : Gelanesaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gelanesaurus cochranae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gelanesaurus_cochranae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1819695;
}
