namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Threskiornis;

/// <summary>
/// Species: Threskiornis molucca
/// NCBI TaxId: 2671080
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Threskiornis_molucca : Threskiornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Threskiornis molucca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Threskiornis_molucca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2671080;
}
