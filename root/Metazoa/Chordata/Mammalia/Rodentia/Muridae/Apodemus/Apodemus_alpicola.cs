namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus alpicola
/// NCBI TaxId: 100381
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_alpicola : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus alpicola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_alpicola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100381;
}
