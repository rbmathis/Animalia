namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Petaurus;

/// <summary>
/// Species: Petaurus sp.
/// NCBI TaxId: 3122667
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petaurus_sp : Petaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petaurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petaurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3122667;
}
