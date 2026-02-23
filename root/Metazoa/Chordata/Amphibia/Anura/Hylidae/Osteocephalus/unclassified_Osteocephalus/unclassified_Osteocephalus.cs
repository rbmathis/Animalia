using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus.unclassified_Osteocephalus;

/// <summary>
/// Abstract class for unclassified Osteocephalus (no rank).
/// NCBI TaxId: 2617853
/// </summary>
public abstract class unclassified_Osteocephalus : Osteocephalus, Iunclassified_Osteocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617853;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteocephalus";
}
