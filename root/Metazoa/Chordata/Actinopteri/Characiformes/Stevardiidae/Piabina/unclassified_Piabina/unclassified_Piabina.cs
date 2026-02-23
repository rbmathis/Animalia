using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Piabina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Piabina.unclassified_Piabina;

/// <summary>
/// Abstract class for unclassified Piabina (no rank).
/// NCBI TaxId: 2624205
/// </summary>
public abstract class unclassified_Piabina : Piabina, Iunclassified_Piabina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Piabina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624205;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Piabina";
}
