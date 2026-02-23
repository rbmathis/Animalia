namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

/// <summary>
/// Species: Mammuthus columbi
/// NCBI TaxId: 1027716
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammuthus_columbi : Mammuthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammuthus columbi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammuthus_columbi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1027716;
}
