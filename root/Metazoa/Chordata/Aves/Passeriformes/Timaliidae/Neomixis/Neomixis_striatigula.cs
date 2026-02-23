namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Neomixis;

/// <summary>
/// Species: Neomixis striatigula
/// NCBI TaxId: 98136
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neomixis_striatigula : Neomixis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neomixis striatigula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neomixis_striatigula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98136;
}
