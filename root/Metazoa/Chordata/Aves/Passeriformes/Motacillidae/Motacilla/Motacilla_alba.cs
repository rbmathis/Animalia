namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Motacilla;

/// <summary>
/// Species: Motacilla alba
/// NCBI TaxId: 45807
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Motacilla_alba : Motacilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Motacilla alba";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Motacilla_alba";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45807;
}
