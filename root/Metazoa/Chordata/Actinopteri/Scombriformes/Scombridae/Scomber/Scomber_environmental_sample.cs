namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomber;

/// <summary>
/// Species: Scomber environmental sample
/// NCBI TaxId: 1494894
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scomber_environmental_sample : Scomber
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scomber environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scomber_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1494894;
}
