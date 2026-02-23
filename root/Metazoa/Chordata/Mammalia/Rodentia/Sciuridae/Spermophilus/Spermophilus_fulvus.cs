namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilus;

/// <summary>
/// Species: Spermophilus fulvus
/// NCBI TaxId: 99841
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spermophilus_fulvus : Spermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spermophilus fulvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spermophilus_fulvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99841;
}
