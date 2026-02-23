namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus hawaiiensis
/// NCBI TaxId: 2316477
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_hawaiiensis : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus hawaiiensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_hawaiiensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2316477;
}
