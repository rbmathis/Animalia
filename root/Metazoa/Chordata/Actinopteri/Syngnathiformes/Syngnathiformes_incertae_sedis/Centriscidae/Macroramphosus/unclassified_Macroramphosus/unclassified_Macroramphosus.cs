using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae.Macroramphosus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae.Macroramphosus.unclassified_Macroramphosus;

/// <summary>
/// Abstract class for unclassified Macroramphosus (no rank).
/// NCBI TaxId: 2647607
/// </summary>
public abstract class unclassified_Macroramphosus : Macroramphosus, Iunclassified_Macroramphosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macroramphosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647607;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macroramphosus";
}
