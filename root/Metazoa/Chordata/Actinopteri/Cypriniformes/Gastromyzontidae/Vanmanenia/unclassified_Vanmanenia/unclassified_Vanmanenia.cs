using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Vanmanenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Vanmanenia.unclassified_Vanmanenia;

/// <summary>
/// Abstract class for unclassified Vanmanenia (no rank).
/// NCBI TaxId: 2635095
/// </summary>
public abstract class unclassified_Vanmanenia : Vanmanenia, Iunclassified_Vanmanenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vanmanenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vanmanenia";
}
