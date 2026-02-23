using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Lissocampus;

/// <summary>
/// Abstract class for Lissocampus (genus).
/// NCBI TaxId: 1914726
/// </summary>
public abstract class Lissocampus : Syngnathidae, ILissocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lissocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914726;

    /// <inheritdoc />
    public virtual string GenusName => "Lissocampus";

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
