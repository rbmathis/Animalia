namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chibchanomys;

/// <summary>
/// Species: Chibchanomys sp.
/// NCBI TaxId: 3115251
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chibchanomys_sp : Chibchanomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chibchanomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chibchanomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3115251;
}
