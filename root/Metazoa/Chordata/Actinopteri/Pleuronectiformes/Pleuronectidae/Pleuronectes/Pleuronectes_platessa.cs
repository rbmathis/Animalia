namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronectes;

/// <summary>
/// Species: Pleuronectes platessa
/// NCBI TaxId: 8262
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pleuronectes_platessa : Pleuronectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pleuronectes platessa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pleuronectes_platessa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8262;
}
