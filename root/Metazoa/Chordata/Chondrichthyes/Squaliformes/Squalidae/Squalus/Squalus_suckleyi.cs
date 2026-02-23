namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus suckleyi
/// NCBI TaxId: 7798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_suckleyi : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus suckleyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_suckleyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7798;
}
