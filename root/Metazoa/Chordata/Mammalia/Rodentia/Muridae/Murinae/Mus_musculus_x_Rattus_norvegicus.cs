namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Murinae;

/// <summary>
/// Species: Mus musculus x Rattus norvegicus
/// NCBI TaxId: 36237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_musculus_x_Rattus_norvegicus : Murinae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus musculus x Rattus norvegicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_musculus_x_Rattus_norvegicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36237;
}
