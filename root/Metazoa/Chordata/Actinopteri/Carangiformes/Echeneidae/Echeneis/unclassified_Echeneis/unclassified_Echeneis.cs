using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Echeneis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Echeneis.unclassified_Echeneis;

/// <summary>
/// Abstract class for unclassified Echeneis (no rank).
/// NCBI TaxId: 3049923
/// </summary>
public abstract class unclassified_Echeneis : Echeneis, Iunclassified_Echeneis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Echeneis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Echeneis";
}
