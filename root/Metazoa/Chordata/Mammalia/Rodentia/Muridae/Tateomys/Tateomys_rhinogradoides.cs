namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tateomys;

/// <summary>
/// Species: Tateomys rhinogradoides
/// NCBI TaxId: 1795476
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tateomys_rhinogradoides : Tateomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tateomys rhinogradoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tateomys_rhinogradoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1795476;
}
