namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta;

/// <summary>
/// Species: Dasyprocta leporina
/// NCBI TaxId: 42152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyprocta_leporina : Dasyprocta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyprocta leporina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyprocta_leporina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42152;
}
