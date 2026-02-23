namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hydrosaurus;

/// <summary>
/// Species: Hydrosaurus sp. 1 CDS-2013
/// NCBI TaxId: 1433298
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrosaurus_sp_1_CDS_2013 : Hydrosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrosaurus sp. 1 CDS-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrosaurus_sp_1_CDS_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1433298;
}
