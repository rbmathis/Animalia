namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Campylorhynchus;

/// <summary>
/// Species: Campylorhynchus capistratus
/// NCBI TaxId: 330144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Campylorhynchus_capistratus : Campylorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Campylorhynchus capistratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Campylorhynchus_capistratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 330144;
}
