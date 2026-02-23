namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus;

/// <summary>
/// Species: Carcharhinus sp. MV-2009
/// NCBI TaxId: 661146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carcharhinus_sp_MV_2009 : Carcharhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carcharhinus sp. MV-2009";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carcharhinus_sp_MV_2009";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 661146;
}
