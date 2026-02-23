using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Papiliolebias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Papiliolebias.unclassified_Papiliolebias;

/// <summary>
/// Abstract class for unclassified Papiliolebias (no rank).
/// NCBI TaxId: 2620231
/// </summary>
public abstract class unclassified_Papiliolebias : Papiliolebias, Iunclassified_Papiliolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Papiliolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620231;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Papiliolebias";
}
