namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Rhizomys;

/// <summary>
/// Species: Rhizomys sp. TCZ-2012
/// NCBI TaxId: 1194074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhizomys_sp_TCZ_2012 : Rhizomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhizomys sp. TCZ-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhizomys_sp_TCZ_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1194074;
}
