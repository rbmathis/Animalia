using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae.Adrianichthys;

/// <summary>
/// Abstract class for Adrianichthys (genus).
/// NCBI TaxId: 1231056
/// </summary>
public abstract class Adrianichthys : Adrianichthyidae, IAdrianichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adrianichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1231056;

    /// <inheritdoc />
    public virtual string GenusName => "Adrianichthys";

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
