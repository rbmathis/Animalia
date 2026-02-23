namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla picta
/// NCBI TaxId: 2744377
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_picta : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla picta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_picta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2744377;
}
