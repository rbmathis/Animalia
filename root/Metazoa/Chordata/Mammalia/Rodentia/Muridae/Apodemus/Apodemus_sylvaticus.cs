namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus sylvaticus
/// NCBI TaxId: 10129
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_sylvaticus : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus sylvaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_sylvaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10129;
}
