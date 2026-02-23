namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinella;

/// <summary>
/// Species: Sardinella sp. 2 TY
/// NCBI TaxId: 2014802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardinella_sp_2_TY : Sardinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardinella sp. 2 TY";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardinella_sp_2_TY";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2014802;
}
