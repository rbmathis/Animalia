namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico;

/// <summary>
/// Species: Mico argentatus
/// NCBI TaxId: 9482
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mico_argentatus : Mico
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mico argentatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mico_argentatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9482;
}
