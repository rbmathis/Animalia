namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.unclassified_Testudines;

/// <summary>
/// Species: Testudines gen. sp.
/// NCBI TaxId: 128804
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Testudines_gen_sp : unclassified_Testudines
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Testudines gen. sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Testudines_gen_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 128804;
}
