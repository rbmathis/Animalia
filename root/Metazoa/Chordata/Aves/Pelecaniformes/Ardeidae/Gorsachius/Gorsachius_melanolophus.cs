namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Gorsachius;

/// <summary>
/// Species: Gorsachius melanolophus
/// NCBI TaxId: 752197
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gorsachius_melanolophus : Gorsachius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gorsachius melanolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gorsachius_melanolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 752197;
}
