namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nectomys;

/// <summary>
/// Species: Nectomys sp. BOLD:AAM5477
/// NCBI TaxId: 1106474
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nectomys_sp_BOLDAAM5477 : Nectomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nectomys sp. BOLD:AAM5477";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nectomys_sp_BOLDAAM5477";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1106474;
}
