using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Colorhamphus;

/// <summary>
/// Abstract class for Colorhamphus (genus).
/// NCBI TaxId: 555239
/// </summary>
public abstract class Colorhamphus : Tyrannidae, IColorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555239;

    /// <inheritdoc />
    public virtual string GenusName => "Colorhamphus";

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
