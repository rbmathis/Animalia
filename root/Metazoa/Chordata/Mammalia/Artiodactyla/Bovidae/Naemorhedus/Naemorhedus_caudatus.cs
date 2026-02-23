namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus;

/// <summary>
/// Species: Naemorhedus caudatus
/// NCBI TaxId: 37173
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naemorhedus_caudatus : Naemorhedus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naemorhedus caudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naemorhedus_caudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37173;
}
