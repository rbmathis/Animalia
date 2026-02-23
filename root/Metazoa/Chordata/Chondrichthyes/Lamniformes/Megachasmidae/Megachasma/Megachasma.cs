using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Megachasmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Megachasmidae.Megachasma;

/// <summary>
/// Abstract class for Megachasma (genus).
/// NCBI TaxId: 57984
/// </summary>
public abstract class Megachasma : Megachasmidae, IMegachasma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megachasma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57984;

    /// <inheritdoc />
    public virtual string GenusName => "Megachasma";

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
