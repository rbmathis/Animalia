namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus;

/// <summary>
/// Species: Carcharhinus obscurus x Carcharhinus galapagensis
/// NCBI TaxId: 2570313
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carcharhinus_obscurus_x_Carcharhinus_galapagensis : Carcharhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carcharhinus obscurus x Carcharhinus galapagensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carcharhinus_obscurus_x_Carcharhinus_galapagensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2570313;
}
