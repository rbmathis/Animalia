namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Nesomys;

/// <summary>
/// Species: Nesomys rufus
/// NCBI TaxId: 52812
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nesomys_rufus : Nesomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nesomys rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nesomys_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52812;
}
