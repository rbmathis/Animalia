namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oryx;

/// <summary>
/// Species: Oryx gazella
/// NCBI TaxId: 9958
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryx_gazella : Oryx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryx gazella";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryx_gazella";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9958;
}
