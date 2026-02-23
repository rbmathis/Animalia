namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Luciogobius;

/// <summary>
/// Species: Luciogobius sp.
/// NCBI TaxId: 3098773
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Luciogobius_sp : Luciogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Luciogobius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Luciogobius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3098773;
}
