namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Neophocaena;

/// <summary>
/// Species: Neophocaena phocaenoides
/// NCBI TaxId: 34892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neophocaena_phocaenoides : Neophocaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neophocaena phocaenoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neophocaena_phocaenoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34892;
}
