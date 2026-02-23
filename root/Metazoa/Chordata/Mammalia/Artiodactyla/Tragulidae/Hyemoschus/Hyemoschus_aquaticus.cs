namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae.Hyemoschus;

/// <summary>
/// Species: Hyemoschus aquaticus
/// NCBI TaxId: 666915
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyemoschus_aquaticus : Hyemoschus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyemoschus aquaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyemoschus_aquaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 666915;
}
