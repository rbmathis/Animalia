namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Phloeomys;

/// <summary>
/// Species: Phloeomys pallidus
/// NCBI TaxId: 1330388
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phloeomys_pallidus : Phloeomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phloeomys pallidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phloeomys_pallidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1330388;
}
