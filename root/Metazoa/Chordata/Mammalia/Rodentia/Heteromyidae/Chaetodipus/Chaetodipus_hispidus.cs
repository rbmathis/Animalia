namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Chaetodipus;

/// <summary>
/// Species: Chaetodipus hispidus
/// NCBI TaxId: 38665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetodipus_hispidus : Chaetodipus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetodipus hispidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetodipus_hispidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38665;
}
