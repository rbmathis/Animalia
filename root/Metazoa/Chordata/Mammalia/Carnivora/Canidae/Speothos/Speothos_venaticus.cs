namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Speothos;

/// <summary>
/// Species: Speothos venaticus
/// NCBI TaxId: 68741
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Speothos_venaticus : Speothos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Speothos venaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Speothos_venaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68741;
}
