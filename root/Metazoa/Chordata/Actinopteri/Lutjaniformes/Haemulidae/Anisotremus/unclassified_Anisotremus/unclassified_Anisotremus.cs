using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Anisotremus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Anisotremus.unclassified_Anisotremus;

/// <summary>
/// Abstract class for unclassified Anisotremus (no rank).
/// NCBI TaxId: 2629500
/// </summary>
public abstract class unclassified_Anisotremus : Anisotremus, Iunclassified_Anisotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anisotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629500;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anisotremus";
}
