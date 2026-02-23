namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus;

/// <summary>
/// Species: Carcharhinus falciformis
/// NCBI TaxId: 202609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carcharhinus_falciformis : Carcharhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carcharhinus falciformis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carcharhinus_falciformis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 202609;
}
