namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer griseus
/// NCBI TaxId: 150916
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_griseus : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150916;
}
