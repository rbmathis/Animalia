namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Species: Ateles fusciceps
/// NCBI TaxId: 9508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateles_fusciceps : Ateles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateles fusciceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateles_fusciceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9508;
}
