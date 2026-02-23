namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Callosciurus;

/// <summary>
/// Species: Callosciurus sp. 2 MG-2013
/// NCBI TaxId: 1430417
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callosciurus_sp_2_MG_2013 : Callosciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callosciurus sp. 2 MG-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callosciurus_sp_2_MG_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1430417;
}
