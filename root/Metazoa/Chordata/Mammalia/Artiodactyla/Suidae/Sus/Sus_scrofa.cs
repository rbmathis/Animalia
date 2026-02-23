namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

/// <summary>
/// Species: Sus scrofa
/// NCBI TaxId: 9823
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sus_scrofa : Sus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sus scrofa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sus_scrofa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9823;
}
