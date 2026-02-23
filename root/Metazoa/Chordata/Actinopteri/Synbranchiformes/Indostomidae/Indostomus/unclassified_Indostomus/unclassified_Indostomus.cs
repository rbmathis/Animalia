using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae.Indostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae.Indostomus.unclassified_Indostomus;

/// <summary>
/// Abstract class for unclassified Indostomus (no rank).
/// NCBI TaxId: 2619793
/// </summary>
public abstract class unclassified_Indostomus : Indostomus, Iunclassified_Indostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Indostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619793;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Indostomus";
}
