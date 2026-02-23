namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Rhinoptera;

/// <summary>
/// Species: Rhinoptera steindachneri
/// NCBI TaxId: 86375
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinoptera_steindachneri : Rhinoptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinoptera steindachneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinoptera_steindachneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 86375;
}
