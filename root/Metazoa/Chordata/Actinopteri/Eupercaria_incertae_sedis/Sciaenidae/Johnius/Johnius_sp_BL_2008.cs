namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius sp. BL-2008
/// NCBI TaxId: 546521
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_sp_BL_2008 : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius sp. BL-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_sp_BL_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 546521;
}
