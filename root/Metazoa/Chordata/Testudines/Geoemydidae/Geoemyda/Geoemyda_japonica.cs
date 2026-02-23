namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Geoemyda;

/// <summary>
/// Species: Geoemyda japonica
/// NCBI TaxId: 204960
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geoemyda_japonica : Geoemyda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geoemyda japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geoemyda_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 204960;
}
