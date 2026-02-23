namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Necromys;

/// <summary>
/// Species: Necromys obscurus
/// NCBI TaxId: 399317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Necromys_obscurus : Necromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Necromys obscurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Necromys_obscurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 399317;
}
