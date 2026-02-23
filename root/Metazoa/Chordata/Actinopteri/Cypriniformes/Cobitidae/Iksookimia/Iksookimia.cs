using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Iksookimia;

/// <summary>
/// Abstract class for Iksookimia (genus).
/// NCBI TaxId: 457513
/// </summary>
public abstract class Iksookimia : Cobitidae, IIksookimia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iksookimia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 457513;

    /// <inheritdoc />
    public virtual string GenusName => "Iksookimia";

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
