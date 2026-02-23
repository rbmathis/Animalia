namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Pegasus;

/// <summary>
/// Species: Pegasus sp. SAA-2015
/// NCBI TaxId: 1700855
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pegasus_sp_SAA_2015 : Pegasus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pegasus sp. SAA-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pegasus_sp_SAA_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1700855;
}
