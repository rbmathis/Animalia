namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus dukecampbelli
/// NCBI TaxId: 3370254
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_dukecampbelli : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus dukecampbelli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_dukecampbelli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370254;
}
