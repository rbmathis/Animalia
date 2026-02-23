namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Sciaena;

/// <summary>
/// Species: Sciaena umbra
/// NCBI TaxId: 1586296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciaena_umbra : Sciaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciaena umbra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciaena_umbra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1586296;
}
