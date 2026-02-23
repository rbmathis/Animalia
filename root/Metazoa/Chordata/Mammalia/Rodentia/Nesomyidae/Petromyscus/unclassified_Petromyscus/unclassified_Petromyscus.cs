using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Petromyscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Petromyscus.unclassified_Petromyscus;

/// <summary>
/// Abstract class for unclassified Petromyscus (no rank).
/// NCBI TaxId: 2631831
/// </summary>
public abstract class unclassified_Petromyscus : Petromyscus, Iunclassified_Petromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631831;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petromyscus";
}
