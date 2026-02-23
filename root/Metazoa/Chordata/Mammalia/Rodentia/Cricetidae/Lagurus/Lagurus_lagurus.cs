namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lagurus;

/// <summary>
/// Species: Lagurus lagurus
/// NCBI TaxId: 175522
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagurus_lagurus : Lagurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagurus lagurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagurus_lagurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175522;
}
