namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae.Xantusia;

/// <summary>
/// Species: Xantusia sp. Magdalena
/// NCBI TaxId: 270505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xantusia_sp_Magdalena : Xantusia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xantusia sp. Magdalena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xantusia_sp_Magdalena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 270505;
}
