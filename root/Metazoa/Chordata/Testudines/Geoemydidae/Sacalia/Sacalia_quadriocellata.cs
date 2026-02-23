namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Sacalia;

/// <summary>
/// Species: Sacalia quadriocellata
/// NCBI TaxId: 74934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sacalia_quadriocellata : Sacalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sacalia quadriocellata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sacalia_quadriocellata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74934;
}
