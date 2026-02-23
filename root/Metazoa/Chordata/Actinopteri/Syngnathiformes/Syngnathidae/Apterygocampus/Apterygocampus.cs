using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Apterygocampus;

/// <summary>
/// Abstract class for Apterygocampus (genus).
/// NCBI TaxId: 1914708
/// </summary>
public abstract class Apterygocampus : Syngnathidae, IApterygocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apterygocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914708;

    /// <inheritdoc />
    public virtual string GenusName => "Apterygocampus";

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
