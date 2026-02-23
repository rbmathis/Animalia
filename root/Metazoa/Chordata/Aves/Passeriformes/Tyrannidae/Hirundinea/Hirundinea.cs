using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Hirundinea;

/// <summary>
/// Abstract class for Hirundinea (genus).
/// NCBI TaxId: 495201
/// </summary>
public abstract class Hirundinea : Tyrannidae, IHirundinea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hirundinea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495201;

    /// <inheritdoc />
    public virtual string GenusName => "Hirundinea";

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
