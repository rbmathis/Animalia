namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Petaurus;

/// <summary>
/// Species: Petaurus australis
/// NCBI TaxId: 282342
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petaurus_australis : Petaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petaurus australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petaurus_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 282342;
}
