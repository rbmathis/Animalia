namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Leptonychotes;

/// <summary>
/// Species: Leptonychotes weddellii
/// NCBI TaxId: 9713
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptonychotes_weddellii : Leptonychotes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptonychotes weddellii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptonychotes_weddellii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9713;
}
