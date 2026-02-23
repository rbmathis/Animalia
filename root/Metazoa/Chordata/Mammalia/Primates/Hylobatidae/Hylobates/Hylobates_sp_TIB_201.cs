namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Species: Hylobates sp. TIB-201
/// NCBI TaxId: 150249
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylobates_sp_TIB_201 : Hylobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylobates sp. TIB-201";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylobates_sp_TIB_201";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150249;
}
