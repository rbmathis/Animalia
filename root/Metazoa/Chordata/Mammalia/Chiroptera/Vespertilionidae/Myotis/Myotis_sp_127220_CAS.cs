namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis sp. 1272/20_CAS
/// NCBI TaxId: 2926358
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_sp_127220_CAS : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis sp. 1272/20_CAS";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_sp_127220_CAS";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2926358;
}
