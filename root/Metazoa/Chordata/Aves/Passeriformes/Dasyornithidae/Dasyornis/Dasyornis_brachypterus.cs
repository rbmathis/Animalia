namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dasyornithidae.Dasyornis;

/// <summary>
/// Species: Dasyornis brachypterus
/// NCBI TaxId: 722651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyornis_brachypterus : Dasyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyornis brachypterus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyornis_brachypterus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 722651;
}
