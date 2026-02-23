namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys speciosus
/// NCBI TaxId: 3370444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_speciosus : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys speciosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_speciosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370444;
}
