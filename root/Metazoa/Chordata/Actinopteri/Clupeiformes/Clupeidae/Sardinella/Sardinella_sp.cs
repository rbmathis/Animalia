namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinella;

/// <summary>
/// Species: Sardinella sp.
/// NCBI TaxId: 3112283
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardinella_sp : Sardinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardinella sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardinella_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3112283;
}
