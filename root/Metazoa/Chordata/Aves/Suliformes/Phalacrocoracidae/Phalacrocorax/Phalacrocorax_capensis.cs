namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae.Phalacrocorax;

/// <summary>
/// Species: Phalacrocorax capensis
/// NCBI TaxId: 146614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalacrocorax_capensis : Phalacrocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalacrocorax capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalacrocorax_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 146614;
}
