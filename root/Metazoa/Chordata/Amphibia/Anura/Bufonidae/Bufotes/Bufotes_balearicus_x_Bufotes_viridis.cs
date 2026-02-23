namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufotes;

/// <summary>
/// Species: Bufotes balearicus x Bufotes viridis
/// NCBI TaxId: 1501131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufotes_balearicus_x_Bufotes_viridis : Bufotes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufotes balearicus x Bufotes viridis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufotes_balearicus_x_Bufotes_viridis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1501131;
}
