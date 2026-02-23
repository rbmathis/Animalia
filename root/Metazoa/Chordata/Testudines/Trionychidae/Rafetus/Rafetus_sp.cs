namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Rafetus;

/// <summary>
/// Species: Rafetus sp.
/// NCBI TaxId: 2804323
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rafetus_sp : Rafetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rafetus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rafetus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804323;
}
