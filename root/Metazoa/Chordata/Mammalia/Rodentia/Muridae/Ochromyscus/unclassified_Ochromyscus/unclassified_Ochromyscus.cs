using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ochromyscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ochromyscus.unclassified_Ochromyscus;

/// <summary>
/// Abstract class for unclassified Ochromyscus (no rank).
/// NCBI TaxId: 3035880
/// </summary>
public abstract class unclassified_Ochromyscus : Ochromyscus, Iunclassified_Ochromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ochromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3035880;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ochromyscus";
}
