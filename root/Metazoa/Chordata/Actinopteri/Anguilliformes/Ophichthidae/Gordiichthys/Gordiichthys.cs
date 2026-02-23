using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Gordiichthys;

/// <summary>
/// Abstract class for Gordiichthys (genus).
/// NCBI TaxId: 2100583
/// </summary>
public abstract class Gordiichthys : Ophichthidae, IGordiichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gordiichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2100583;

    /// <inheritdoc />
    public virtual string GenusName => "Gordiichthys";

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
