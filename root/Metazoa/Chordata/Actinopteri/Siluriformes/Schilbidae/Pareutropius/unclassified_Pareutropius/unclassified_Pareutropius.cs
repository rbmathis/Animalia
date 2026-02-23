using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Pareutropius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Pareutropius.unclassified_Pareutropius;

/// <summary>
/// Abstract class for unclassified Pareutropius (no rank).
/// NCBI TaxId: 2640182
/// </summary>
public abstract class unclassified_Pareutropius : Pareutropius, Iunclassified_Pareutropius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pareutropius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640182;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pareutropius";
}
