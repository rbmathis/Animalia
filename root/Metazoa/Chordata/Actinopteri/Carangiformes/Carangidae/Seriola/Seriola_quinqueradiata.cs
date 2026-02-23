namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Seriola;

/// <summary>
/// Species: Seriola quinqueradiata
/// NCBI TaxId: 8161
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Seriola_quinqueradiata : Seriola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Seriola quinqueradiata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Seriola_quinqueradiata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8161;
}
