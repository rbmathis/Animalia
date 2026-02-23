using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Merlangius;

/// <summary>
/// Abstract class for Merlangius (genus).
/// NCBI TaxId: 8057
/// </summary>
public abstract class Merlangius : Gadidae, IMerlangius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Merlangius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8057;

    /// <inheritdoc />
    public virtual string GenusName => "Merlangius";

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
