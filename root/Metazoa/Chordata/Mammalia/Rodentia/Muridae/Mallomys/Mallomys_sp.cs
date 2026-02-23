namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mallomys;

/// <summary>
/// Species: Mallomys sp.
/// NCBI TaxId: 3079507
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mallomys_sp : Mallomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mallomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mallomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3079507;
}
