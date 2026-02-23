namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiobius;

/// <summary>
/// Species: Myiobius barbatus
/// NCBI TaxId: 190023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiobius_barbatus : Myiobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiobius barbatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiobius_barbatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190023;
}
