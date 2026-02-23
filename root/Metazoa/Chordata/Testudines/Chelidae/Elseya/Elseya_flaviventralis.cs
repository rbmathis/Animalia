namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya flaviventralis
/// NCBI TaxId: 3146409
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_flaviventralis : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya flaviventralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_flaviventralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3146409;
}
