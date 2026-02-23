namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus ursulus
/// NCBI TaxId: 2918763
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_ursulus : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus ursulus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_ursulus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2918763;
}
