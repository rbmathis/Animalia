namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Species: Stegastes albifasciatus
/// NCBI TaxId: 997984
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stegastes_albifasciatus : Stegastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stegastes albifasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stegastes_albifasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 997984;
}
