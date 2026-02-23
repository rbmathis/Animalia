namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus uralensis
/// NCBI TaxId: 134910
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_uralensis : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus uralensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_uralensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 134910;
}
