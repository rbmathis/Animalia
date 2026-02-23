namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Caprimulgus;

/// <summary>
/// Species: Caprimulgus sp.
/// NCBI TaxId: 3044227
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caprimulgus_sp : Caprimulgus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caprimulgus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caprimulgus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3044227;
}
