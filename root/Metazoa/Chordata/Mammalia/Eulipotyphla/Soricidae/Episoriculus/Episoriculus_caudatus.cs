namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Episoriculus;

/// <summary>
/// Species: Episoriculus caudatus
/// NCBI TaxId: 62291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Episoriculus_caudatus : Episoriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Episoriculus caudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Episoriculus_caudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62291;
}
