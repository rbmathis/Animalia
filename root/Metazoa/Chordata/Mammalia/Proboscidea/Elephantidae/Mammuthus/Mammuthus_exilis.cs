namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

/// <summary>
/// Species: Mammuthus exilis
/// NCBI TaxId: 1851653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammuthus_exilis : Mammuthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammuthus exilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammuthus_exilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1851653;
}
