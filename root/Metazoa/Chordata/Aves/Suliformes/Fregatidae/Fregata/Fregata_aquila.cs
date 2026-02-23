namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Fregatidae.Fregata;

/// <summary>
/// Species: Fregata aquila
/// NCBI TaxId: 244445
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Fregata_aquila : Fregata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Fregata aquila";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Fregata_aquila";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 244445;
}
