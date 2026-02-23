namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Mimus;

/// <summary>
/// Species: Mimus gilvus
/// NCBI TaxId: 111998
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mimus_gilvus : Mimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mimus gilvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mimus_gilvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111998;
}
