namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Zapus;

/// <summary>
/// Species: Zapus hudsonius
/// NCBI TaxId: 160400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zapus_hudsonius : Zapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zapus hudsonius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zapus_hudsonius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160400;
}
