namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crunomys;

/// <summary>
/// Species: Crunomys melanius
/// NCBI TaxId: 349703
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crunomys_melanius : Crunomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crunomys melanius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crunomys_melanius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 349703;
}
