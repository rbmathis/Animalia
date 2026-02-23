namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophuromys;

/// <summary>
/// Species: Lophuromys chercherensis
/// NCBI TaxId: 2774393
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophuromys_chercherensis : Lophuromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophuromys chercherensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophuromys_chercherensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2774393;
}
