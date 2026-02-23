namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thamnomys;

/// <summary>
/// Species: Thamnomys sp.
/// NCBI TaxId: 1890066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thamnomys_sp : Thamnomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thamnomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thamnomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1890066;
}
