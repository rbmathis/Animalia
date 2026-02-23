using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Pantanodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Pantanodontidae.Aliteranodon;

/// <summary>
/// Abstract class for Aliteranodon (genus).
/// NCBI TaxId: 3363379
/// </summary>
public abstract class Aliteranodon : Pantanodontidae, IAliteranodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aliteranodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363379;

    /// <inheritdoc />
    public virtual string GenusName => "Aliteranodon";

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
