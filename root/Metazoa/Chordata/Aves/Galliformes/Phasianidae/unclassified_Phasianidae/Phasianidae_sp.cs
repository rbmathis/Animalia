namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.unclassified_Phasianidae;

/// <summary>
/// Species: Phasianidae sp.
/// NCBI TaxId: 9006
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phasianidae_sp : unclassified_Phasianidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phasianidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phasianidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9006;
}
