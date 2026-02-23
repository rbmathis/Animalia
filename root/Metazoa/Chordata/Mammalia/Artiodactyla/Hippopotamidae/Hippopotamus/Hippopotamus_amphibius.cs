namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hippopotamus;

/// <summary>
/// Species: Hippopotamus amphibius
/// NCBI TaxId: 9833
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippopotamus_amphibius : Hippopotamus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippopotamus amphibius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippopotamus_amphibius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9833;
}
