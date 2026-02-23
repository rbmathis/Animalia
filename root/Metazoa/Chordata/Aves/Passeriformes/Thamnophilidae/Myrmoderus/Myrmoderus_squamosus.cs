namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmoderus;

/// <summary>
/// Species: Myrmoderus squamosus
/// NCBI TaxId: 2765396
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myrmoderus_squamosus : Myrmoderus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myrmoderus squamosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myrmoderus_squamosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2765396;
}
