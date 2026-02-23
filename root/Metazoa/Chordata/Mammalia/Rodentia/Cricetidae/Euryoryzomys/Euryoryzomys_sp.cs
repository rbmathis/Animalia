namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euryoryzomys;

/// <summary>
/// Species: Euryoryzomys sp.
/// NCBI TaxId: 3040049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euryoryzomys_sp : Euryoryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euryoryzomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euryoryzomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3040049;
}
