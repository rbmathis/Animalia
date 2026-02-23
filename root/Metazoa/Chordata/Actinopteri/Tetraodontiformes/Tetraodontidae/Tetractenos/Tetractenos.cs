using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Tetractenos;

/// <summary>
/// Abstract class for Tetractenos (genus).
/// NCBI TaxId: 303745
/// </summary>
public abstract class Tetractenos : Tetraodontidae, ITetractenos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetractenos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303745;

    /// <inheritdoc />
    public virtual string GenusName => "Tetractenos";

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
