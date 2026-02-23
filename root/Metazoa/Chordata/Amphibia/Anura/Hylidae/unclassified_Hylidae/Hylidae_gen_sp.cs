namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.unclassified_Hylidae;

/// <summary>
/// Species: Hylidae gen. sp.
/// NCBI TaxId: 95144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylidae_gen_sp : unclassified_Hylidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylidae gen. sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylidae_gen_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95144;
}
