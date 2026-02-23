namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sphaenorhynchus;

/// <summary>
/// Species: Sphaenorhynchus prasinus
/// NCBI TaxId: 2420077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphaenorhynchus_prasinus : Sphaenorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphaenorhynchus prasinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphaenorhynchus_prasinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2420077;
}
