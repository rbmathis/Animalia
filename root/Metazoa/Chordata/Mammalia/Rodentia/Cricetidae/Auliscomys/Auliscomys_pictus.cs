namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Auliscomys;

/// <summary>
/// Species: Auliscomys pictus
/// NCBI TaxId: 29104
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Auliscomys_pictus : Auliscomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Auliscomys pictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Auliscomys_pictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29104;
}
