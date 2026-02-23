namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Alces;

/// <summary>
/// Species: Alces alces
/// NCBI TaxId: 9852
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alces_alces : Alces
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alces alces";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alces_alces";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9852;
}
