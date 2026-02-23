namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Kassina;

/// <summary>
/// Species: Kassina senegalensis
/// NCBI TaxId: 8415
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kassina_senegalensis : Kassina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kassina senegalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kassina_senegalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8415;
}
