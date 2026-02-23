using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Neenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Neenchelys.unclassified_Neenchelys;

/// <summary>
/// Abstract class for unclassified Neenchelys (no rank).
/// NCBI TaxId: 2644357
/// </summary>
public abstract class unclassified_Neenchelys : Neenchelys, Iunclassified_Neenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644357;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neenchelys";
}
