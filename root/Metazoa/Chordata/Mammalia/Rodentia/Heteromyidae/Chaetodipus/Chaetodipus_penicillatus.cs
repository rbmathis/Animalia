namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Chaetodipus;

/// <summary>
/// Species: Chaetodipus penicillatus
/// NCBI TaxId: 38672
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetodipus_penicillatus : Chaetodipus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetodipus penicillatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetodipus_penicillatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38672;
}
