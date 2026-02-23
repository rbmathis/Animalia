namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Monodactylidae.Monodactylus;

/// <summary>
/// Species: Monodactylus sp. BL-2008
/// NCBI TaxId: 546528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monodactylus_sp_BL_2008 : Monodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monodactylus sp. BL-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monodactylus_sp_BL_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 546528;
}
