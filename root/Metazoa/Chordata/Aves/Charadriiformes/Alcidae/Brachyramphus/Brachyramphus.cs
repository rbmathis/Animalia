using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Brachyramphus;

/// <summary>
/// Abstract class for Brachyramphus (genus).
/// NCBI TaxId: 28692
/// </summary>
public abstract class Brachyramphus : Alcidae, IBrachyramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28692;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyramphus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
