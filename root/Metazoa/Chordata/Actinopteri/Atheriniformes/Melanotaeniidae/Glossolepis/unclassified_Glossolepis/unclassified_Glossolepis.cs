using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Glossolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Glossolepis.unclassified_Glossolepis;

/// <summary>
/// Abstract class for unclassified Glossolepis (no rank).
/// NCBI TaxId: 2640441
/// </summary>
public abstract class unclassified_Glossolepis : Glossolepis, Iunclassified_Glossolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glossolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640441;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glossolepis";
}
