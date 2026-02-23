namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmoderus;

/// <summary>
/// Species: Myrmoderus ferrugineus
/// NCBI TaxId: 468493
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myrmoderus_ferrugineus : Myrmoderus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myrmoderus ferrugineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myrmoderus_ferrugineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 468493;
}
