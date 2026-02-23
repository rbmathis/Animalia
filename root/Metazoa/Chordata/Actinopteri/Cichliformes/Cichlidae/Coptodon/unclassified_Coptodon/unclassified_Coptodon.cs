using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Coptodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Coptodon.unclassified_Coptodon;

/// <summary>
/// Abstract class for unclassified Coptodon (no rank).
/// NCBI TaxId: 2629058
/// </summary>
public abstract class unclassified_Coptodon : Coptodon, Iunclassified_Coptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629058;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coptodon";
}
