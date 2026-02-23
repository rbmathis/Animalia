using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Obliquogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Obliquogobius.unclassified_Obliquogobius;

/// <summary>
/// Abstract class for unclassified Obliquogobius (no rank).
/// NCBI TaxId: 2677725
/// </summary>
public abstract class unclassified_Obliquogobius : Obliquogobius, Iunclassified_Obliquogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Obliquogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677725;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Obliquogobius";
}
