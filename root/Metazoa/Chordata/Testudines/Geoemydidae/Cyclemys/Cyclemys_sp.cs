namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

/// <summary>
/// Species: Cyclemys sp.
/// NCBI TaxId: 2804321
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclemys_sp : Cyclemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclemys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclemys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804321;
}
