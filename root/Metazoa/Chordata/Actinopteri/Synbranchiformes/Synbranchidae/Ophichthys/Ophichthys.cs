using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Ophichthys;

/// <summary>
/// Abstract class for Ophichthys (genus).
/// NCBI TaxId: 2793284
/// </summary>
public abstract class Ophichthys : Synbranchidae, IOphichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2793284;

    /// <inheritdoc />
    public virtual string GenusName => "Ophichthys";

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
