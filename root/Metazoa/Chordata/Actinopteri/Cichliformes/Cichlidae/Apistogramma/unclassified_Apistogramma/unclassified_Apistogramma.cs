using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Apistogramma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Apistogramma.unclassified_Apistogramma;

/// <summary>
/// Abstract class for unclassified Apistogramma (no rank).
/// NCBI TaxId: 2685010
/// </summary>
public abstract class unclassified_Apistogramma : Apistogramma, Iunclassified_Apistogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apistogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685010;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apistogramma";
}
