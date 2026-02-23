namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Poicephalus;

/// <summary>
/// Species: Poicephalus flavifrons
/// NCBI TaxId: 2495904
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poicephalus_flavifrons : Poicephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poicephalus flavifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poicephalus_flavifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2495904;
}
