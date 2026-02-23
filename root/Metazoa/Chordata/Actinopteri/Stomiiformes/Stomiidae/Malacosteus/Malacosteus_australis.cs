namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Malacosteus;

/// <summary>
/// Species: Malacosteus australis
/// NCBI TaxId: 2578300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malacosteus_australis : Malacosteus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malacosteus australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malacosteus_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2578300;
}
