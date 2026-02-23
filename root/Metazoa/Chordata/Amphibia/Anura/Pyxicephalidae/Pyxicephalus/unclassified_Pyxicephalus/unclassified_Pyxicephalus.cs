using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Pyxicephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Pyxicephalus.unclassified_Pyxicephalus;

/// <summary>
/// Abstract class for unclassified Pyxicephalus (no rank).
/// NCBI TaxId: 3053561
/// </summary>
public abstract class unclassified_Pyxicephalus : Pyxicephalus, Iunclassified_Pyxicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyxicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3053561;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyxicephalus";
}
