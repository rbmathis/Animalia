using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Thynnichthys;

/// <summary>
/// Abstract class for Thynnichthys (genus).
/// NCBI TaxId: 643449
/// </summary>
public abstract class Thynnichthys : Cyprinidae, IThynnichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thynnichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643449;

    /// <inheritdoc />
    public virtual string GenusName => "Thynnichthys";

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
