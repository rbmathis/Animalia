namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picus;

/// <summary>
/// Species: Picus chlorolophus
/// NCBI TaxId: 367952
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picus_chlorolophus : Picus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picus chlorolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picus_chlorolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 367952;
}
