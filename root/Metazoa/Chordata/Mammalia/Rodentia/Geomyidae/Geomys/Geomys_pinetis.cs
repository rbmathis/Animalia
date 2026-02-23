namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Species: Geomys pinetis
/// NCBI TaxId: 100306
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geomys_pinetis : Geomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geomys pinetis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geomys_pinetis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100306;
}
