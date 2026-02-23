using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Anarchias;

/// <summary>
/// Abstract class for Anarchias (genus).
/// NCBI TaxId: 556234
/// </summary>
public abstract class Anarchias : Muraenidae, IAnarchias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anarchias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556234;

    /// <inheritdoc />
    public virtual string GenusName => "Anarchias";

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
