namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Capreolus;

/// <summary>
/// Species: Capreolus pygargus
/// NCBI TaxId: 48560
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capreolus_pygargus : Capreolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capreolus pygargus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capreolus_pygargus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48560;
}
