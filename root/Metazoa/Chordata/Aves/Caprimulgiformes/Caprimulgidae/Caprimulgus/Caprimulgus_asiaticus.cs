namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Caprimulgus;

/// <summary>
/// Species: Caprimulgus asiaticus
/// NCBI TaxId: 3044219
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caprimulgus_asiaticus : Caprimulgus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caprimulgus asiaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caprimulgus_asiaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3044219;
}
