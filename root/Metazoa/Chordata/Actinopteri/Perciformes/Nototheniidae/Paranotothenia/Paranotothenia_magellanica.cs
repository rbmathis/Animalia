namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Paranotothenia;

/// <summary>
/// Species: Paranotothenia magellanica
/// NCBI TaxId: 37005
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paranotothenia_magellanica : Paranotothenia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paranotothenia magellanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paranotothenia_magellanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37005;
}
