namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus;

/// <summary>
/// Species: Atelopus sp. 'Cusco'
/// NCBI TaxId: 551675
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atelopus_sp_Cusco : Atelopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atelopus sp. 'Cusco'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atelopus_sp_Cusco";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 551675;
}
