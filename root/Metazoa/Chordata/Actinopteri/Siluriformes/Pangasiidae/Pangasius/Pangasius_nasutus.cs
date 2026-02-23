namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius nasutus
/// NCBI TaxId: 796021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_nasutus : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius nasutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_nasutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 796021;
}
