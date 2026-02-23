namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius amblycephalus
/// NCBI TaxId: 912805
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_amblycephalus : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius amblycephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_amblycephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 912805;
}
