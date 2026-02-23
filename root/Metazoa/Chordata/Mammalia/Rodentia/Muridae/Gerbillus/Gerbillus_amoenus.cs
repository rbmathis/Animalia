namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillus;

/// <summary>
/// Species: Gerbillus amoenus
/// NCBI TaxId: 1564266
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbillus_amoenus : Gerbillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbillus amoenus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbillus_amoenus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1564266;
}
