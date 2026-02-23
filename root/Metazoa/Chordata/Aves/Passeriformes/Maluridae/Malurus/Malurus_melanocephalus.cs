namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Malurus;

/// <summary>
/// Species: Malurus melanocephalus
/// NCBI TaxId: 175006
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malurus_melanocephalus : Malurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malurus melanocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malurus_melanocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175006;
}
