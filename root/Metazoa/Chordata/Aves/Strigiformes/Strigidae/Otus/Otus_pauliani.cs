namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus pauliani
/// NCBI TaxId: 543870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_pauliani : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus pauliani";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_pauliani";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 543870;
}
