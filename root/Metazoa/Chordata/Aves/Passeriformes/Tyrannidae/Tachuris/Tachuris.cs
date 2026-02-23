using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tachuris;

/// <summary>
/// Abstract class for Tachuris (genus).
/// NCBI TaxId: 495161
/// </summary>
public abstract class Tachuris : Tyrannidae, ITachuris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachuris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495161;

    /// <inheritdoc />
    public virtual string GenusName => "Tachuris";

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
