using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Phyllomyias;

/// <summary>
/// Abstract class for Phyllomyias (genus).
/// NCBI TaxId: 360229
/// </summary>
public abstract class Phyllomyias : Tyrannidae, IPhyllomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360229;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllomyias";

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
