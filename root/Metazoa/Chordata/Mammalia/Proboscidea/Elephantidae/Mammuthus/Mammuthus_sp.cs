namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

/// <summary>
/// Species: Mammuthus sp.
/// NCBI TaxId: 1851651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammuthus_sp : Mammuthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammuthus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammuthus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1851651;
}
