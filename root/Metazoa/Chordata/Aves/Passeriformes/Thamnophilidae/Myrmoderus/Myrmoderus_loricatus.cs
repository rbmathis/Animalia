namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmoderus;

/// <summary>
/// Species: Myrmoderus loricatus
/// NCBI TaxId: 2765395
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myrmoderus_loricatus : Myrmoderus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myrmoderus loricatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myrmoderus_loricatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2765395;
}
