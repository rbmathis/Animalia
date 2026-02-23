namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Rafetus;

/// <summary>
/// Species: Rafetus swinhoei
/// NCBI TaxId: 904230
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rafetus_swinhoei : Rafetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rafetus swinhoei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rafetus_swinhoei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904230;
}
