namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus hermonensis
/// NCBI TaxId: 159078
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_hermonensis : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus hermonensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_hermonensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 159078;
}
