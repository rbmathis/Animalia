namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arizona;

/// <summary>
/// Species: Arizona pacata
/// NCBI TaxId: 2316901
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arizona_pacata : Arizona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arizona pacata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arizona_pacata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2316901;
}
