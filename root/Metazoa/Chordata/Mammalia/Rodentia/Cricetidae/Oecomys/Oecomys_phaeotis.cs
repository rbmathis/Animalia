namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys phaeotis
/// NCBI TaxId: 2382073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_phaeotis : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys phaeotis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_phaeotis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2382073;
}
