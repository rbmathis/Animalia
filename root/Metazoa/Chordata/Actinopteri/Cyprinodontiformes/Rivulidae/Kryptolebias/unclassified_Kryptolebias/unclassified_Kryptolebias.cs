using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Kryptolebias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Kryptolebias.unclassified_Kryptolebias;

/// <summary>
/// Abstract class for unclassified Kryptolebias (no rank).
/// NCBI TaxId: 2926298
/// </summary>
public abstract class unclassified_Kryptolebias : Kryptolebias, Iunclassified_Kryptolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kryptolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2926298;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kryptolebias";
}
