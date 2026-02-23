namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Monopterus;

/// <summary>
/// Species: Monopterus sp. sensu Tachihara, 2015
/// NCBI TaxId: 3350317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monopterus_sp_sensu_Tachihara_2015 : Monopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monopterus sp. sensu Tachihara, 2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monopterus_sp_sensu_Tachihara_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3350317;
}
