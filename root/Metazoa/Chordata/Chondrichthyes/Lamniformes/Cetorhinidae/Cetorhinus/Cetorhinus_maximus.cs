namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Cetorhinidae.Cetorhinus;

/// <summary>
/// Species: Cetorhinus maximus
/// NCBI TaxId: 57982
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cetorhinus_maximus : Cetorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cetorhinus maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cetorhinus_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57982;
}
