namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.unclassified_Camelidae;

/// <summary>
/// Species: Camelidae sp.
/// NCBI TaxId: 3396592
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camelidae_sp : unclassified_Camelidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camelidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camelidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3396592;
}
