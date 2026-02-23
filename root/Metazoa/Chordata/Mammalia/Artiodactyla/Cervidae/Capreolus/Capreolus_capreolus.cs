namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Capreolus;

/// <summary>
/// Species: Capreolus capreolus
/// NCBI TaxId: 9858
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capreolus_capreolus : Capreolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capreolus capreolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capreolus_capreolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9858;
}
