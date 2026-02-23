using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Acentrogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Acentrogobius.unclassified_Acentrogobius;

/// <summary>
/// Abstract class for unclassified Acentrogobius (no rank).
/// NCBI TaxId: 2630365
/// </summary>
public abstract class unclassified_Acentrogobius : Acentrogobius, Iunclassified_Acentrogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acentrogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630365;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acentrogobius";
}
