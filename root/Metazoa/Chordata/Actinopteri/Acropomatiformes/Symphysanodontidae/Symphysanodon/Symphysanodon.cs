using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae.Symphysanodon;

/// <summary>
/// Abstract class for Symphysanodon (genus).
/// NCBI TaxId: 722447
/// </summary>
public abstract class Symphysanodon : Symphysanodontidae, ISymphysanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphysanodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722447;

    /// <inheritdoc />
    public virtual string GenusName => "Symphysanodon";

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
