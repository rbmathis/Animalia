using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Masturus;

/// <summary>
/// Abstract class for Masturus (genus).
/// NCBI TaxId: 223210
/// </summary>
public abstract class Masturus : Molidae, IMasturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Masturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223210;

    /// <inheritdoc />
    public virtual string GenusName => "Masturus";

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
