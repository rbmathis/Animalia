namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama sp. MSR-2010
/// NCBI TaxId: 766174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_sp_MSR_2010 : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama sp. MSR-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_sp_MSR_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 766174;
}
