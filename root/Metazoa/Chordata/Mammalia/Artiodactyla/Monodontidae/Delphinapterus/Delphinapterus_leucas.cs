namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae.Delphinapterus;

/// <summary>
/// Species: Delphinapterus leucas
/// NCBI TaxId: 9749
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Delphinapterus_leucas : Delphinapterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Delphinapterus leucas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Delphinapterus_leucas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9749;
}
