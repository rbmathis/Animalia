using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Barbatula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Barbatula.unclassified_Barbatula;

/// <summary>
/// Abstract class for unclassified Barbatula (no rank).
/// NCBI TaxId: 2638223
/// </summary>
public abstract class unclassified_Barbatula : Barbatula, Iunclassified_Barbatula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barbatula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638223;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barbatula";
}
