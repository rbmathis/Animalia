namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Nycticorax;

/// <summary>
/// Species: Nycticorax nycticorax
/// NCBI TaxId: 8901
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nycticorax_nycticorax : Nycticorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nycticorax nycticorax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nycticorax_nycticorax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8901;
}
