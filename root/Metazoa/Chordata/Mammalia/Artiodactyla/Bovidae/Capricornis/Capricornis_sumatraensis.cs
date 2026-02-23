namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capricornis;

/// <summary>
/// Species: Capricornis sumatraensis
/// NCBI TaxId: 34865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capricornis_sumatraensis : Capricornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capricornis sumatraensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capricornis_sumatraensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34865;
}
