namespace AnimalKingdom.root.Metazoa.Chordata.Tyrannosauridae.Tyrannosaurus;

/// <summary>
/// Species: Tyrannosaurus rex
/// NCBI TaxId: 436495
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyrannosaurus_rex : Tyrannosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyrannosaurus rex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyrannosaurus_rex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 436495;
}
