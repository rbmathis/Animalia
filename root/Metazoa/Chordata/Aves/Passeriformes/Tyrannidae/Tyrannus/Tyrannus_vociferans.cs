namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tyrannus;

/// <summary>
/// Species: Tyrannus vociferans
/// NCBI TaxId: 372372
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyrannus_vociferans : Tyrannus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyrannus vociferans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyrannus_vociferans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 372372;
}
