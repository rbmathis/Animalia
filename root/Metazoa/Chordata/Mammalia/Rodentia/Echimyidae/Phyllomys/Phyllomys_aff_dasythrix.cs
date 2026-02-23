namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys;

/// <summary>
/// Species: Phyllomys aff. dasythrix
/// NCBI TaxId: 466166
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllomys_aff_dasythrix : Phyllomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllomys aff. dasythrix";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllomys_aff_dasythrix";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 466166;
}
