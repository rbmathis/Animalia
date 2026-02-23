namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Bonasa;

/// <summary>
/// Species: Bonasa umbellus
/// NCBI TaxId: 9000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bonasa_umbellus : Bonasa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bonasa umbellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bonasa_umbellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9000;
}
