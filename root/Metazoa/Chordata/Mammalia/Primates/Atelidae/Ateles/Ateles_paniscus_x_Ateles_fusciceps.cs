namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Species: Ateles paniscus x Ateles fusciceps
/// NCBI TaxId: 36234
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateles_paniscus_x_Ateles_fusciceps : Ateles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateles paniscus x Ateles fusciceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateles_paniscus_x_Ateles_fusciceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36234;
}
