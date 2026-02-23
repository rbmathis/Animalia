namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Oryctolagus;

/// <summary>
/// Species: Oryctolagus cuniculus
/// NCBI TaxId: 9986
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryctolagus_cuniculus : Oryctolagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryctolagus cuniculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryctolagus_cuniculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9986;
}
