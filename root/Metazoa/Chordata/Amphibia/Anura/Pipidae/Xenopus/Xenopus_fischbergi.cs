namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus fischbergi
/// NCBI TaxId: 451448
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_fischbergi : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus fischbergi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_fischbergi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 451448;
}
