namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae.Gaidropsarus;

/// <summary>
/// Species: Gaidropsarus mediterraneus
/// NCBI TaxId: 426100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gaidropsarus_mediterraneus : Gaidropsarus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gaidropsarus mediterraneus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gaidropsarus_mediterraneus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 426100;
}
