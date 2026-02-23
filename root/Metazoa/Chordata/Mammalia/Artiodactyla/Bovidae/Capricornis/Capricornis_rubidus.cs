namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capricornis;

/// <summary>
/// Species: Capricornis rubidus
/// NCBI TaxId: 2664340
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capricornis_rubidus : Capricornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capricornis rubidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capricornis_rubidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2664340;
}
