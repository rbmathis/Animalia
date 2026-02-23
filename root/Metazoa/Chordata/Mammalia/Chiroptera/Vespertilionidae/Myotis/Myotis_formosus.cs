namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis formosus
/// NCBI TaxId: 225401
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_formosus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis formosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_formosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 225401;
}
