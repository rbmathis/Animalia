using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Menuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Menuridae.Atrichornis;

/// <summary>
/// Abstract class for Atrichornis (genus).
/// NCBI TaxId: 449593
/// </summary>
public abstract class Atrichornis : Menuridae, IAtrichornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atrichornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449593;

    /// <inheritdoc />
    public virtual string GenusName => "Atrichornis";

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
