using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiromyscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiromyscus.unclassified_Chiromyscus;

/// <summary>
/// Abstract class for unclassified Chiromyscus (no rank).
/// NCBI TaxId: 2630232
/// </summary>
public abstract class unclassified_Chiromyscus : Chiromyscus, Iunclassified_Chiromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630232;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiromyscus";
}
