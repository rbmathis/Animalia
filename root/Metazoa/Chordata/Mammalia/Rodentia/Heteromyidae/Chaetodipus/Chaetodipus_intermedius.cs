namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Chaetodipus;

/// <summary>
/// Species: Chaetodipus intermedius
/// NCBI TaxId: 38666
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetodipus_intermedius : Chaetodipus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetodipus intermedius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetodipus_intermedius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38666;
}
