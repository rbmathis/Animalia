using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Tricholestes;

/// <summary>
/// Abstract class for Tricholestes (genus).
/// NCBI TaxId: 147059
/// </summary>
public abstract class Tricholestes : Pycnonotidae, ITricholestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tricholestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147059;

    /// <inheritdoc />
    public virtual string GenusName => "Tricholestes";

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
