namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tyrannus;

/// <summary>
/// Species: Tyrannus verticalis x Tyrannus forficatus
/// NCBI TaxId: 2545718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyrannus_verticalis_x_Tyrannus_forficatus : Tyrannus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyrannus verticalis x Tyrannus forficatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyrannus_verticalis_x_Tyrannus_forficatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2545718;
}
