using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Aspredinichthys;

/// <summary>
/// Abstract class for Aspredinichthys (genus).
/// NCBI TaxId: 2175996
/// </summary>
public abstract class Aspredinichthys : Aspredinidae, IAspredinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspredinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2175996;

    /// <inheritdoc />
    public virtual string GenusName => "Aspredinichthys";

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
