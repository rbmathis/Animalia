using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paraschistura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paraschistura.unclassified_Paraschistura;

/// <summary>
/// Abstract class for unclassified Paraschistura (no rank).
/// NCBI TaxId: 2633347
/// </summary>
public abstract class unclassified_Paraschistura : Paraschistura, Iunclassified_Paraschistura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraschistura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633347;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraschistura";
}
