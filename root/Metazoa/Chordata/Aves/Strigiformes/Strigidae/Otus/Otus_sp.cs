namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus sp.
/// NCBI TaxId: 2924936
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_sp : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2924936;
}
