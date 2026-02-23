using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Microlophichthys;

/// <summary>
/// Abstract class for Microlophichthys (genus).
/// NCBI TaxId: 1738898
/// </summary>
public abstract class Microlophichthys : Oneirodidae, IMicrolophichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microlophichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1738898;

    /// <inheritdoc />
    public virtual string GenusName => "Microlophichthys";

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
