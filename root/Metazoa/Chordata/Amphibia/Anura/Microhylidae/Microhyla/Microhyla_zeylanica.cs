namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla zeylanica
/// NCBI TaxId: 2497939
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_zeylanica : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla zeylanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_zeylanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2497939;
}
