namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Argyrosomus;

/// <summary>
/// Species: Argyrosomus japonicus
/// NCBI TaxId: 448029
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Argyrosomus_japonicus : Argyrosomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Argyrosomus japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Argyrosomus_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 448029;
}
