using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Crenicara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Crenicara.unclassified_Crenicara;

/// <summary>
/// Abstract class for unclassified Crenicara (no rank).
/// NCBI TaxId: 2646944
/// </summary>
public abstract class unclassified_Crenicara : Crenicara, Iunclassified_Crenicara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crenicara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646944;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crenicara";
}
