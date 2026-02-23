namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Indopacetus;

/// <summary>
/// Species: Indopacetus pacificus
/// NCBI TaxId: 221924
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indopacetus_pacificus : Indopacetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indopacetus pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indopacetus_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221924;
}
