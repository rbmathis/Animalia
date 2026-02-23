namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus rufescens
/// NCBI TaxId: 2653989
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_rufescens : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2653989;
}
