using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.unclassified_Schilbeidae;

/// <summary>
/// Abstract class for unclassified Schilbeidae (no rank).
/// NCBI TaxId: 1920799
/// </summary>
public abstract class unclassified_Schilbeidae : Schilbidae, Iunclassified_Schilbeidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schilbeidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1920799;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schilbeidae";
}
