using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus.unclassified_Peromyscus;

/// <summary>
/// Abstract class for unclassified Peromyscus (no rank).
/// NCBI TaxId: 2623844
/// </summary>
public abstract class unclassified_Peromyscus : Peromyscus, Iunclassified_Peromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Peromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623844;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Peromyscus";
}
