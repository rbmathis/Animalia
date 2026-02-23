namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Assessor;

/// <summary>
/// Species: Assessor flavissimus
/// NCBI TaxId: 546543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Assessor_flavissimus : Assessor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Assessor flavissimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Assessor_flavissimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 546543;
}
