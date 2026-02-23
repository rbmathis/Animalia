namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae.Phalacrocorax;

/// <summary>
/// Species: Phalacrocorax featherstoni
/// NCBI TaxId: 146622
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalacrocorax_featherstoni : Phalacrocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalacrocorax featherstoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalacrocorax_featherstoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 146622;
}
