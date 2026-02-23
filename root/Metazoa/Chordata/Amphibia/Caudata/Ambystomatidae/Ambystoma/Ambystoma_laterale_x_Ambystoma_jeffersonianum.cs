namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Ambystomatidae.Ambystoma;

/// <summary>
/// Species: Ambystoma laterale x Ambystoma jeffersonianum
/// NCBI TaxId: 8299
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ambystoma_laterale_x_Ambystoma_jeffersonianum : Ambystoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ambystoma laterale x Ambystoma jeffersonianum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ambystoma_laterale_x_Ambystoma_jeffersonianum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8299;
}
