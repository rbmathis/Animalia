namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Melomys;

/// <summary>
/// Species: Melomys rubicola
/// NCBI TaxId: 442586
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melomys_rubicola : Melomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melomys rubicola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melomys_rubicola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442586;
}
