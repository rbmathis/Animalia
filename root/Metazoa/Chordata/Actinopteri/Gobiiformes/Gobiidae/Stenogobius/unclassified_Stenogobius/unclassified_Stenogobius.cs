using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stenogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stenogobius.unclassified_Stenogobius;

/// <summary>
/// Abstract class for unclassified Stenogobius (no rank).
/// NCBI TaxId: 2685005
/// </summary>
public abstract class unclassified_Stenogobius : Stenogobius, Iunclassified_Stenogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stenogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685005;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stenogobius";
}
