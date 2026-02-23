namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

/// <summary>
/// Species: Batis poensis
/// NCBI TaxId: 272804
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batis_poensis : Batis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batis poensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batis_poensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 272804;
}
