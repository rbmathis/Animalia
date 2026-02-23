namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama sp. KKS-2010
/// NCBI TaxId: 881924
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_sp_KKS_2010 : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama sp. KKS-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_sp_KKS_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 881924;
}
