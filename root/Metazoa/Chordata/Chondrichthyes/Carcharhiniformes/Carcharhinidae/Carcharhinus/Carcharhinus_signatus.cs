namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus;

/// <summary>
/// Species: Carcharhinus signatus
/// NCBI TaxId: 303943
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carcharhinus_signatus : Carcharhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carcharhinus signatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carcharhinus_signatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303943;
}
