namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microryzomys;

/// <summary>
/// Species: Microryzomys sp.
/// NCBI TaxId: 3115256
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microryzomys_sp : Microryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microryzomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microryzomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3115256;
}
