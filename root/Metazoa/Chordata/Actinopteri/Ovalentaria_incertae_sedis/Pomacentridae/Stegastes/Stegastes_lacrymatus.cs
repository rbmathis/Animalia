namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Species: Stegastes lacrymatus
/// NCBI TaxId: 80988
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stegastes_lacrymatus : Stegastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stegastes lacrymatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stegastes_lacrymatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 80988;
}
