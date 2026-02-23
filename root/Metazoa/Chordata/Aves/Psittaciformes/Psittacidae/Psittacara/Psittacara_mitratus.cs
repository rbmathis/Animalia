namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara mitratus
/// NCBI TaxId: 136503
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_mitratus : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara mitratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_mitratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 136503;
}
