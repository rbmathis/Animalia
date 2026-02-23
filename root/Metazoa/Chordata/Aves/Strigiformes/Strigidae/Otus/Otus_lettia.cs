namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus lettia
/// NCBI TaxId: 209070
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_lettia : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus lettia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_lettia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 209070;
}
