namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys;

/// <summary>
/// Species: Megophrys gigantica
/// NCBI TaxId: 1903867
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megophrys_gigantica : Megophrys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megophrys gigantica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megophrys_gigantica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1903867;
}
