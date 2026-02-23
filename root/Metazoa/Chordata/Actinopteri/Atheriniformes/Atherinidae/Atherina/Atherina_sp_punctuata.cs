namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherina;

/// <summary>
/// Species: Atherina sp. 'punctuata'
/// NCBI TaxId: 470307
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atherina_sp_punctuata : Atherina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atherina sp. 'punctuata'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atherina_sp_punctuata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 470307;
}
