namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.unclassified_Simiiformes;

/// <summary>
/// Species: Simiiformes sp.
/// NCBI TaxId: 70699
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Simiiformes_sp : unclassified_Simiiformes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Simiiformes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Simiiformes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70699;
}
