namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupea;

/// <summary>
/// Species: Clupea harengus
/// NCBI TaxId: 7950
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clupea_harengus : Clupea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clupea harengus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clupea_harengus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7950;
}
