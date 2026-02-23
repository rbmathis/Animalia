namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Necromys;

/// <summary>
/// Species: Necromys amoenus
/// NCBI TaxId: 10081
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Necromys_amoenus : Necromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Necromys amoenus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Necromys_amoenus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10081;
}
