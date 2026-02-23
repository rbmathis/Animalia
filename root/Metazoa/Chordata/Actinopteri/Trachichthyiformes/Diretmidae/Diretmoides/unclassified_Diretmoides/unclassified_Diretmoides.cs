using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.Diretmoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Diretmidae.Diretmoides.unclassified_Diretmoides;

/// <summary>
/// Abstract class for unclassified Diretmoides (no rank).
/// NCBI TaxId: 2630805
/// </summary>
public abstract class unclassified_Diretmoides : Diretmoides, Iunclassified_Diretmoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diretmoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630805;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diretmoides";
}
