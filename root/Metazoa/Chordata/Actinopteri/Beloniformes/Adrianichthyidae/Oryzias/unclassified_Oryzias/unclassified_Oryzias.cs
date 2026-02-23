using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae.Oryzias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae.Oryzias.unclassified_Oryzias;

/// <summary>
/// Abstract class for unclassified Oryzias (no rank).
/// NCBI TaxId: 2640172
/// </summary>
public abstract class unclassified_Oryzias : Oryzias, Iunclassified_Oryzias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oryzias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640172;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oryzias";
}
