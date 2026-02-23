namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus albifrons
/// NCBI TaxId: 335033
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_albifrons : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus albifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_albifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 335033;
}
