namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Priotelus;

/// <summary>
/// Species: Priotelus roseigaster
/// NCBI TaxId: 297716
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Priotelus_roseigaster : Priotelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Priotelus roseigaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Priotelus_roseigaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 297716;
}
