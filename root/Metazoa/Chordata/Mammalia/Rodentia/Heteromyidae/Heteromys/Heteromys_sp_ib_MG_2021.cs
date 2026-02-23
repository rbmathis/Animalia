namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys;

/// <summary>
/// Species: Heteromys sp. ib MG-2021
/// NCBI TaxId: 2874050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heteromys_sp_ib_MG_2021 : Heteromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heteromys sp. ib MG-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heteromys_sp_ib_MG_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2874050;
}
