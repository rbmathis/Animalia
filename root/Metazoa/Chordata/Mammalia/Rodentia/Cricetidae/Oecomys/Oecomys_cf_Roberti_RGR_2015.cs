namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys cf. Roberti RGR-2015
/// NCBI TaxId: 1660245
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_cf_Roberti_RGR_2015 : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys cf. Roberti RGR-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_cf_Roberti_RGR_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1660245;
}
