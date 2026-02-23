using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Aborichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Aborichthys.unclassified_Aborichthys;

/// <summary>
/// Abstract class for unclassified Aborichthys (no rank).
/// NCBI TaxId: 2649339
/// </summary>
public abstract class unclassified_Aborichthys : Aborichthys, Iunclassified_Aborichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aborichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649339;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aborichthys";
}
