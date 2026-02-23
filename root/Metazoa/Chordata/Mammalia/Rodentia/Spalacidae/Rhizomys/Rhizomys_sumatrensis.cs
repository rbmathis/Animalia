namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Rhizomys;

/// <summary>
/// Species: Rhizomys sumatrensis
/// NCBI TaxId: 2055140
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhizomys_sumatrensis : Rhizomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhizomys sumatrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhizomys_sumatrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2055140;
}
