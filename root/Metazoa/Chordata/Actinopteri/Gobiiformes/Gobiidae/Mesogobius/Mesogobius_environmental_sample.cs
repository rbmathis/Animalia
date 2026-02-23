namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mesogobius;

/// <summary>
/// Species: Mesogobius environmental sample
/// NCBI TaxId: 1623321
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesogobius_environmental_sample : Mesogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesogobius environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesogobius_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1623321;
}
