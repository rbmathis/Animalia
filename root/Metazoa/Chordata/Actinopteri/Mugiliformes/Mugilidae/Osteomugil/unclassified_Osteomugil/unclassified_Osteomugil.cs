using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Osteomugil;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Osteomugil.unclassified_Osteomugil;

/// <summary>
/// Abstract class for unclassified Osteomugil (no rank).
/// NCBI TaxId: 2678928
/// </summary>
public abstract class unclassified_Osteomugil : Osteomugil, Iunclassified_Osteomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2678928;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteomugil";
}
