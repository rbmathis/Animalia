namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capricornis;

/// <summary>
/// Species: Capricornis sp.
/// NCBI TaxId: 1862648
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capricornis_sp : Capricornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capricornis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capricornis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1862648;
}
