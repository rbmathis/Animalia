namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Ceratophrys;

/// <summary>
/// Species: Ceratophrys ornata
/// NCBI TaxId: 30347
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ceratophrys_ornata : Ceratophrys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ceratophrys ornata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ceratophrys_ornata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30347;
}
