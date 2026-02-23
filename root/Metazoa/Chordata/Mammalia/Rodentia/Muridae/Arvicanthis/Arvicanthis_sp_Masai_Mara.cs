namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Arvicanthis;

/// <summary>
/// Species: Arvicanthis sp. 'Masai Mara'
/// NCBI TaxId: 2592600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arvicanthis_sp_Masai_Mara : Arvicanthis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arvicanthis sp. 'Masai Mara'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arvicanthis_sp_Masai_Mara";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2592600;
}
