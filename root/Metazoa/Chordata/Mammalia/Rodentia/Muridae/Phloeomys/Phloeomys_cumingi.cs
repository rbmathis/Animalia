namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Phloeomys;

/// <summary>
/// Species: Phloeomys cumingi
/// NCBI TaxId: 248813
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phloeomys_cumingi : Phloeomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phloeomys cumingi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phloeomys_cumingi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 248813;
}
