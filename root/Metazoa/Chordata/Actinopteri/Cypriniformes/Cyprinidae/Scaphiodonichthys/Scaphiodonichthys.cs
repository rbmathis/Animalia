using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Scaphiodonichthys;

/// <summary>
/// Abstract class for Scaphiodonichthys (genus).
/// NCBI TaxId: 643443
/// </summary>
public abstract class Scaphiodonichthys : Cyprinidae, IScaphiodonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphiodonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643443;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphiodonichthys";

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
