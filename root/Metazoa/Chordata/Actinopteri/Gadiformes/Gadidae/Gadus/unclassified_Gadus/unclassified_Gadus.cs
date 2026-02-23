using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadus.unclassified_Gadus;

/// <summary>
/// Abstract class for unclassified Gadus (no rank).
/// NCBI TaxId: 2627815
/// </summary>
public abstract class unclassified_Gadus : Gadus, Iunclassified_Gadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627815;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gadus";
}
