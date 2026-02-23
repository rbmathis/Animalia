namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Myobatrachus;

/// <summary>
/// Species: Myobatrachus gouldii
/// NCBI TaxId: 251756
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myobatrachus_gouldii : Myobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myobatrachus gouldii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myobatrachus_gouldii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 251756;
}
