using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Ephippion;

/// <summary>
/// Abstract class for Ephippion (genus).
/// NCBI TaxId: 500396
/// </summary>
public abstract class Ephippion : Tetraodontidae, IEphippion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ephippion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 500396;

    /// <inheritdoc />
    public virtual string GenusName => "Ephippion";

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
