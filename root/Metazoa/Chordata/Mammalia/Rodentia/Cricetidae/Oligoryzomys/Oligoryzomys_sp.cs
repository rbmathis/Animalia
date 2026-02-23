namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oligoryzomys;

/// <summary>
/// Species: Oligoryzomys sp.
/// NCBI TaxId: 37019
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oligoryzomys_sp : Oligoryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oligoryzomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oligoryzomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37019;
}
