using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Acanthogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Acanthogobius.unclassified_Acanthogobius;

/// <summary>
/// Abstract class for unclassified Acanthogobius (no rank).
/// NCBI TaxId: 2632168
/// </summary>
public abstract class unclassified_Acanthogobius : Acanthogobius, Iunclassified_Acanthogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632168;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthogobius";
}
