namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Nanger;

/// <summary>
/// Species: Nanger soemmerringii
/// NCBI TaxId: 69306
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nanger_soemmerringii : Nanger
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nanger soemmerringii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nanger_soemmerringii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69306;
}
