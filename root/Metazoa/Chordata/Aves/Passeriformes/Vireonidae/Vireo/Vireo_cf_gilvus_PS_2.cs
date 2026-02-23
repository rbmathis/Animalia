namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Species: Vireo cf. gilvus PS-2
/// NCBI TaxId: 371867
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireo_cf_gilvus_PS_2 : Vireo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireo cf. gilvus PS-2";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireo_cf_gilvus_PS_2";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 371867;
}
