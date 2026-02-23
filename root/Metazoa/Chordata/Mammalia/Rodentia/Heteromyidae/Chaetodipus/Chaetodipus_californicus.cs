namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Chaetodipus;

/// <summary>
/// Species: Chaetodipus californicus
/// NCBI TaxId: 145408
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetodipus_californicus : Chaetodipus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetodipus californicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetodipus_californicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 145408;
}
