namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Myocastoridae.Myocastor;

/// <summary>
/// Species: Myocastor coypus
/// NCBI TaxId: 10157
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myocastor_coypus : Myocastor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myocastor coypus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myocastor_coypus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10157;
}
