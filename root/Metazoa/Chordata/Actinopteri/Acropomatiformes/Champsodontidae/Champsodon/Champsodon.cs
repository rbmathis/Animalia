using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae.Champsodon;

/// <summary>
/// Abstract class for Champsodon (genus).
/// NCBI TaxId: 270611
/// </summary>
public abstract class Champsodon : Champsodontidae, IChampsodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Champsodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270611;

    /// <inheritdoc />
    public virtual string GenusName => "Champsodon";

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
