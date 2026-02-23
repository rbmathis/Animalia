using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Malakichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Malakichthyidae.Malakichthys;

/// <summary>
/// Abstract class for Malakichthys (genus).
/// NCBI TaxId: 223799
/// </summary>
public abstract class Malakichthys : Malakichthyidae, IMalakichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malakichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223799;

    /// <inheritdoc />
    public virtual string GenusName => "Malakichthys";

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
