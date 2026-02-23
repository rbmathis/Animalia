using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Exastilithoxus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Exastilithoxus.unclassified_Exastilithoxus;

/// <summary>
/// Abstract class for unclassified Exastilithoxus (no rank).
/// NCBI TaxId: 2647612
/// </summary>
public abstract class unclassified_Exastilithoxus : Exastilithoxus, Iunclassified_Exastilithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Exastilithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647612;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Exastilithoxus";
}
