namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus chejuensis
/// NCBI TaxId: 754351
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_chejuensis : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus chejuensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_chejuensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 754351;
}
