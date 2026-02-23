namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hydrosaurus;

/// <summary>
/// Species: Hydrosaurus sp. TMT-2011
/// NCBI TaxId: 1009861
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrosaurus_sp_TMT_2011 : Hydrosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrosaurus sp. TMT-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrosaurus_sp_TMT_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1009861;
}
