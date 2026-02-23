namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Thylacinidae.Thylacinus;

/// <summary>
/// Species: Thylacinus cynocephalus
/// NCBI TaxId: 9275
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thylacinus_cynocephalus : Thylacinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thylacinus cynocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thylacinus_cynocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9275;
}
