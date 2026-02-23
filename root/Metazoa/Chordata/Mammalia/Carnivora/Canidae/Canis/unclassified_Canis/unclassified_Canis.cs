using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis.unclassified_Canis;

/// <summary>
/// Abstract class for unclassified Canis (no rank).
/// NCBI TaxId: 2626217
/// </summary>
public abstract class unclassified_Canis : Canis, Iunclassified_Canis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Canis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626217;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Canis";
}
