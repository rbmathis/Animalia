using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Ochthornis;

/// <summary>
/// Abstract class for Ochthornis (genus).
/// NCBI TaxId: 649813
/// </summary>
public abstract class Ochthornis : Tyrannidae, IOchthornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ochthornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 649813;

    /// <inheritdoc />
    public virtual string GenusName => "Ochthornis";

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
