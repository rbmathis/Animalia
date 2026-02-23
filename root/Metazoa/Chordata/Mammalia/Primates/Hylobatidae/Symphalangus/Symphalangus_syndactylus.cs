namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Symphalangus;

/// <summary>
/// Species: Symphalangus syndactylus
/// NCBI TaxId: 9590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Symphalangus_syndactylus : Symphalangus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Symphalangus syndactylus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Symphalangus_syndactylus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9590;
}
