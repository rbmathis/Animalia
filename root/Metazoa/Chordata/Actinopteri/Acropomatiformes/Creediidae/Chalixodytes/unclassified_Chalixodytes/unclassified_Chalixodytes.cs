using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Chalixodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Chalixodytes.unclassified_Chalixodytes;

/// <summary>
/// Abstract class for unclassified Chalixodytes (no rank).
/// NCBI TaxId: 2633489
/// </summary>
public abstract class unclassified_Chalixodytes : Chalixodytes, Iunclassified_Chalixodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chalixodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633489;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chalixodytes";
}
