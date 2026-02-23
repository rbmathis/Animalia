namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus;

/// <summary>
/// Species: Naemorhedus evansi
/// NCBI TaxId: 2746145
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naemorhedus_evansi : Naemorhedus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naemorhedus evansi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naemorhedus_evansi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2746145;
}
