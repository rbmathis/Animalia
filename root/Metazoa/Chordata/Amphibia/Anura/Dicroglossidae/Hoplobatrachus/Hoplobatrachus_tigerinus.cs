namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Hoplobatrachus;

/// <summary>
/// Species: Hoplobatrachus tigerinus
/// NCBI TaxId: 103373
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hoplobatrachus_tigerinus : Hoplobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hoplobatrachus tigerinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hoplobatrachus_tigerinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103373;
}
