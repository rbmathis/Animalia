namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Dactylomys;

/// <summary>
/// Species: Dactylomys boliviensis
/// NCBI TaxId: 30618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dactylomys_boliviensis : Dactylomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dactylomys boliviensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dactylomys_boliviensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30618;
}
