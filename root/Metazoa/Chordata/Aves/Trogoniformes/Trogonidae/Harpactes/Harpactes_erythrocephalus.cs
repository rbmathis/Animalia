namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Harpactes;

/// <summary>
/// Species: Harpactes erythrocephalus
/// NCBI TaxId: 297715
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Harpactes_erythrocephalus : Harpactes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Harpactes erythrocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Harpactes_erythrocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 297715;
}
