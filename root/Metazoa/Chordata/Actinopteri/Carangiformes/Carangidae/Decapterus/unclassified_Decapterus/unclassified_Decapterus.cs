using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Decapterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Decapterus.unclassified_Decapterus;

/// <summary>
/// Abstract class for unclassified Decapterus (no rank).
/// NCBI TaxId: 2635837
/// </summary>
public abstract class unclassified_Decapterus : Decapterus, Iunclassified_Decapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Decapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635837;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Decapterus";
}
