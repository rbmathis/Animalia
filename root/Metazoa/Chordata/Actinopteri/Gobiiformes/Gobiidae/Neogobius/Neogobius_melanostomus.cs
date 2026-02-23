namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Neogobius;

/// <summary>
/// Species: Neogobius melanostomus
/// NCBI TaxId: 47308
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neogobius_melanostomus : Neogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neogobius melanostomus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neogobius_melanostomus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 47308;
}
