namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Cricetomys;

/// <summary>
/// Species: Cricetomys gambianus
/// NCBI TaxId: 10085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cricetomys_gambianus : Cricetomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cricetomys gambianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cricetomys_gambianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10085;
}
