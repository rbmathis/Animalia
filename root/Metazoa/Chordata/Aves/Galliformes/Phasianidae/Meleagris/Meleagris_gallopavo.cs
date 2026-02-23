namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Meleagris;

/// <summary>
/// Species: Meleagris gallopavo
/// NCBI TaxId: 9103
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Meleagris_gallopavo : Meleagris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Meleagris gallopavo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Meleagris_gallopavo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9103;
}
