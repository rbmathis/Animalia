using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae.Aegithalos;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae.Aegithalos.unclassified_Aegithalos;

/// <summary>
/// Abstract class for unclassified Aegithalos (no rank).
/// NCBI TaxId: 2625016
/// </summary>
public abstract class unclassified_Aegithalos : Aegithalos, Iunclassified_Aegithalos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aegithalos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625016;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aegithalos";
}
