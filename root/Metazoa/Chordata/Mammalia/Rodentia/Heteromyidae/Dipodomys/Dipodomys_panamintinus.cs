namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Dipodomys;

/// <summary>
/// Species: Dipodomys panamintinus
/// NCBI TaxId: 10019
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dipodomys_panamintinus : Dipodomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dipodomys panamintinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dipodomys_panamintinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10019;
}
