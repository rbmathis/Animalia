namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo sp. 1 KJ-2019
/// NCBI TaxId: 2599792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_sp_1_KJ_2019 : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo sp. 1 KJ-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_sp_1_KJ_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2599792;
}
