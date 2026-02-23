namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Himantopus;

/// <summary>
/// Species: Himantopus leucocephalus
/// NCBI TaxId: 507594
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Himantopus_leucocephalus : Himantopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Himantopus leucocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Himantopus_leucocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 507594;
}
