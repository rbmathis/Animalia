namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Sooglossidae.Sooglossus;

/// <summary>
/// Species: Sooglossus sechellensis
/// NCBI TaxId: 356330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sooglossus_sechellensis : Sooglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sooglossus sechellensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sooglossus_sechellensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 356330;
}
