namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anatidae_incertae_sedis.Nettapus;

/// <summary>
/// Species: Nettapus auritus
/// NCBI TaxId: 658922
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nettapus_auritus : Nettapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nettapus auritus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nettapus_auritus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 658922;
}
