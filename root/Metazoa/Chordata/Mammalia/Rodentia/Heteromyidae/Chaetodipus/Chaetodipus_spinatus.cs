namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Chaetodipus;

/// <summary>
/// Species: Chaetodipus spinatus
/// NCBI TaxId: 145413
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetodipus_spinatus : Chaetodipus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetodipus spinatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetodipus_spinatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 145413;
}
