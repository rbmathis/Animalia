namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetulus;

/// <summary>
/// Species: Cricetulus sp.
/// NCBI TaxId: 10031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cricetulus_sp : Cricetulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cricetulus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cricetulus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10031;
}
