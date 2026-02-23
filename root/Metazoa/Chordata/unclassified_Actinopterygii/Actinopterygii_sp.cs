namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Actinopterygii;

/// <summary>
/// Species: Actinopterygii sp.
/// NCBI TaxId: 3081885
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinopterygii_sp : unclassified_Actinopterygii
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinopterygii sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinopterygii_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3081885;
}
