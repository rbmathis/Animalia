namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Phasianus;

/// <summary>
/// Species: Phasianus versicolor
/// NCBI TaxId: 9055
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phasianus_versicolor : Phasianus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phasianus versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phasianus_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9055;
}
