namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Litocranius;

/// <summary>
/// Species: Litocranius walleri
/// NCBI TaxId: 69311
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Litocranius_walleri : Litocranius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Litocranius walleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Litocranius_walleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69311;
}
