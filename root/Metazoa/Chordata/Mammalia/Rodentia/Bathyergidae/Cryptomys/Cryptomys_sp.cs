namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys;

/// <summary>
/// Species: Cryptomys sp.
/// NCBI TaxId: 3455486
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptomys_sp : Cryptomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3455486;
}
