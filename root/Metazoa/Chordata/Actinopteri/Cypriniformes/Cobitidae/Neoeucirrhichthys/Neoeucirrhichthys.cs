using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Neoeucirrhichthys;

/// <summary>
/// Abstract class for Neoeucirrhichthys (genus).
/// NCBI TaxId: 457525
/// </summary>
public abstract class Neoeucirrhichthys : Cobitidae, INeoeucirrhichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoeucirrhichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 457525;

    /// <inheritdoc />
    public virtual string GenusName => "Neoeucirrhichthys";

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
