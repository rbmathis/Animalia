namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Species: Berylmys latouchei
/// NCBI TaxId: 3018341
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Berylmys_latouchei : Berylmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Berylmys latouchei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Berylmys_latouchei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3018341;
}
