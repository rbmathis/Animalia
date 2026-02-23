using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Oreichthys;

/// <summary>
/// Abstract class for Oreichthys (genus).
/// NCBI TaxId: 497015
/// </summary>
public abstract class Oreichthys : Cyprinidae, IOreichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497015;

    /// <inheritdoc />
    public virtual string GenusName => "Oreichthys";

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
