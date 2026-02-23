namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

/// <summary>
/// Species: Sus barbatus
/// NCBI TaxId: 41807
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sus_barbatus : Sus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sus barbatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sus_barbatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 41807;
}
