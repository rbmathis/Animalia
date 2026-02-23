namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Dascyllus;

/// <summary>
/// Species: Dascyllus albisella
/// NCBI TaxId: 91608
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dascyllus_albisella : Dascyllus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dascyllus albisella";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dascyllus_albisella";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 91608;
}
