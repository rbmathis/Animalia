namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus insularis
/// NCBI TaxId: 543864
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_insularis : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus insularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_insularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 543864;
}
