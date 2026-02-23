namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Hippocamelus;

/// <summary>
/// Species: Hippocamelus bisulcus
/// NCBI TaxId: 397614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippocamelus_bisulcus : Hippocamelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippocamelus bisulcus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippocamelus_bisulcus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 397614;
}
