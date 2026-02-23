namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Neotamias;

/// <summary>
/// Species: Neotamias grisescens
/// NCBI TaxId: 3370379
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neotamias_grisescens : Neotamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neotamias grisescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neotamias_grisescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370379;
}
