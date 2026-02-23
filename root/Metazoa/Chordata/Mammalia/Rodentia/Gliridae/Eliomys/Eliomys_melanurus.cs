namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Eliomys;

/// <summary>
/// Species: Eliomys melanurus
/// NCBI TaxId: 221695
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eliomys_melanurus : Eliomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eliomys melanurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eliomys_melanurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221695;
}
