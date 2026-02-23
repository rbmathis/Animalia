using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasianodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasianodon.unclassified_Pangasianodon;

/// <summary>
/// Abstract class for unclassified Pangasianodon (no rank).
/// NCBI TaxId: 2643893
/// </summary>
public abstract class unclassified_Pangasianodon : Pangasianodon, Iunclassified_Pangasianodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pangasianodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pangasianodon";
}
