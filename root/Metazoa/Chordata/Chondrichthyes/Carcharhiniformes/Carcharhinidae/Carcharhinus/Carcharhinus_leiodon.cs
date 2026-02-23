namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Carcharhinus;

/// <summary>
/// Species: Carcharhinus leiodon
/// NCBI TaxId: 1046239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carcharhinus_leiodon : Carcharhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carcharhinus leiodon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carcharhinus_leiodon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1046239;
}
