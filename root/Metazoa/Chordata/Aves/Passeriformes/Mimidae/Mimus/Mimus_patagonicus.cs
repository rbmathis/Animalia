namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Mimus;

/// <summary>
/// Species: Mimus patagonicus
/// NCBI TaxId: 175008
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mimus_patagonicus : Mimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mimus patagonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mimus_patagonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175008;
}
