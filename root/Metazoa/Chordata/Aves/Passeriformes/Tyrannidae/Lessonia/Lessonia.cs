using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Lessonia;

/// <summary>
/// Abstract class for Lessonia (genus).
/// NCBI TaxId: 123642
/// </summary>
public abstract class Lessonia : Tyrannidae, ILessonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lessonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123642;

    /// <inheritdoc />
    public virtual string GenusName => "Lessonia";

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
