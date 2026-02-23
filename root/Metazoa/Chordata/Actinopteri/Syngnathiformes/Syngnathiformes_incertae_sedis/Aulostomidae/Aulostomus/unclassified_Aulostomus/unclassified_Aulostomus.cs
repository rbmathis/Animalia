using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae.Aulostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae.Aulostomus.unclassified_Aulostomus;

/// <summary>
/// Abstract class for unclassified Aulostomus (no rank).
/// NCBI TaxId: 2635699
/// </summary>
public abstract class unclassified_Aulostomus : Aulostomus, Iunclassified_Aulostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aulostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635699;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aulostomus";
}
