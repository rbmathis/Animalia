namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Species: Stegastes imbricatus
/// NCBI TaxId: 646035
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stegastes_imbricatus : Stegastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stegastes imbricatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stegastes_imbricatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 646035;
}
