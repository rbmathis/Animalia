namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Elaphe;

/// <summary>
/// Species: Elaphe quadrivirgata
/// NCBI TaxId: 86195
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elaphe_quadrivirgata : Elaphe
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elaphe quadrivirgata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elaphe_quadrivirgata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 86195;
}
