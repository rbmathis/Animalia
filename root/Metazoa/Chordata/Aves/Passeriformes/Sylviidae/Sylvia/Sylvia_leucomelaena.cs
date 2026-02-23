namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvia;

/// <summary>
/// Species: Sylvia leucomelaena
/// NCBI TaxId: 216215
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvia_leucomelaena : Sylvia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvia leucomelaena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvia_leucomelaena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 216215;
}
