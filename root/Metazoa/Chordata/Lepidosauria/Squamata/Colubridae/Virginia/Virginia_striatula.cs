namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Virginia;

/// <summary>
/// Species: Virginia striatula
/// NCBI TaxId: 183606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Virginia_striatula : Virginia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Virginia striatula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Virginia_striatula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 183606;
}
