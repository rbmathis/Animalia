namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurillus;

/// <summary>
/// Species: Petaurillus kinlochii
/// NCBI TaxId: 226815
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petaurillus_kinlochii : Petaurillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petaurillus kinlochii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petaurillus_kinlochii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226815;
}
