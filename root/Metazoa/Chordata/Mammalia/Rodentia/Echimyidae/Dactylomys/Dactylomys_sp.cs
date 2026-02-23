namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Dactylomys;

/// <summary>
/// Species: Dactylomys sp.
/// NCBI TaxId: 3115253
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dactylomys_sp : Dactylomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dactylomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dactylomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3115253;
}
