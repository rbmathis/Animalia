namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Paynomys;

/// <summary>
/// Species: Paynomys macronyx
/// NCBI TaxId: 29109
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paynomys_macronyx : Paynomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paynomys macronyx";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paynomys_macronyx";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29109;
}
