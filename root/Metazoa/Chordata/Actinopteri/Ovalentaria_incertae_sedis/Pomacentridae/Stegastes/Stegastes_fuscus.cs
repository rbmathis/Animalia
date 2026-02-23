namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Species: Stegastes fuscus
/// NCBI TaxId: 1268095
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stegastes_fuscus : Stegastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stegastes fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stegastes_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1268095;
}
