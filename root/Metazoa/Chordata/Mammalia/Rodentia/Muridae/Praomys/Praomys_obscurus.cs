namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys obscurus
/// NCBI TaxId: 1116256
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_obscurus : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys obscurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_obscurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1116256;
}
