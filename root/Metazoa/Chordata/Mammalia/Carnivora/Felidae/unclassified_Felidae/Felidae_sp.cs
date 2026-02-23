namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.unclassified_Felidae;

/// <summary>
/// Species: Felidae sp.
/// NCBI TaxId: 1935980
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felidae_sp : unclassified_Felidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1935980;
}
