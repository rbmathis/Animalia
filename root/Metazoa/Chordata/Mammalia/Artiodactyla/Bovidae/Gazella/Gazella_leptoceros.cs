namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Gazella;

/// <summary>
/// Species: Gazella leptoceros
/// NCBI TaxId: 69303
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gazella_leptoceros : Gazella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gazella leptoceros";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gazella_leptoceros";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69303;
}
