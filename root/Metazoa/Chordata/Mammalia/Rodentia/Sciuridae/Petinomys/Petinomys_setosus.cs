namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petinomys;

/// <summary>
/// Species: Petinomys setosus
/// NCBI TaxId: 100947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petinomys_setosus : Petinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petinomys setosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petinomys_setosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100947;
}
