namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Tachyoryctes;

/// <summary>
/// Species: Tachyoryctes sp.
/// NCBI TaxId: 123371
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachyoryctes_sp : Tachyoryctes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachyoryctes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachyoryctes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123371;
}
