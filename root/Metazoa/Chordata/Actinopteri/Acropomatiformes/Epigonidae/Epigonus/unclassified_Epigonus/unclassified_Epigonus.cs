using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Epigonus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Epigonus.unclassified_Epigonus;

/// <summary>
/// Abstract class for unclassified Epigonus (no rank).
/// NCBI TaxId: 2685253
/// </summary>
public abstract class unclassified_Epigonus : Epigonus, Iunclassified_Epigonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epigonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685253;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epigonus";
}
