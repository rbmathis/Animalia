namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Oenomys;

/// <summary>
/// Species: Oenomys hypoxanthus
/// NCBI TaxId: 332668
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oenomys_hypoxanthus : Oenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oenomys hypoxanthus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oenomys_hypoxanthus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332668;
}
