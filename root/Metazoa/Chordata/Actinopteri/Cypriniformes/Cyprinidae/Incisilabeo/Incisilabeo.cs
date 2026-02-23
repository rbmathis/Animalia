using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Incisilabeo;

/// <summary>
/// Abstract class for Incisilabeo (genus).
/// NCBI TaxId: 1204387
/// </summary>
public abstract class Incisilabeo : Cyprinidae, IIncisilabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Incisilabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1204387;

    /// <inheritdoc />
    public virtual string GenusName => "Incisilabeo";

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
