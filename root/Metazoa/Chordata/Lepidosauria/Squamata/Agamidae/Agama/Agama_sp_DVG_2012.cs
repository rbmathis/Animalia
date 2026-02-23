namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama sp. DVG-2012
/// NCBI TaxId: 1197713
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_sp_DVG_2012 : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama sp. DVG-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_sp_DVG_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1197713;
}
