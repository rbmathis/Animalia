using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Desmopuntius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Desmopuntius.unclassified_Desmopuntius;

/// <summary>
/// Abstract class for unclassified Desmopuntius (no rank).
/// NCBI TaxId: 3420384
/// </summary>
public abstract class unclassified_Desmopuntius : Desmopuntius, Iunclassified_Desmopuntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Desmopuntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3420384;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Desmopuntius";
}
