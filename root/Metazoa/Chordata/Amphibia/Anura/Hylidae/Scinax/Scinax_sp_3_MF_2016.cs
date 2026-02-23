namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax sp. 3 MF-2016
/// NCBI TaxId: 1873131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_sp_3_MF_2016 : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax sp. 3 MF-2016";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_sp_3_MF_2016";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1873131;
}
