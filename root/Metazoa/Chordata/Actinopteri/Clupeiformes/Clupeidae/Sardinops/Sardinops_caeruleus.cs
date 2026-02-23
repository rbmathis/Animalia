namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinops;

/// <summary>
/// Species: Sardinops caeruleus
/// NCBI TaxId: 196073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardinops_caeruleus : Sardinops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardinops caeruleus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardinops_caeruleus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 196073;
}
