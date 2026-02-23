namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla marmorata
/// NCBI TaxId: 946360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_marmorata : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla marmorata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_marmorata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 946360;
}
