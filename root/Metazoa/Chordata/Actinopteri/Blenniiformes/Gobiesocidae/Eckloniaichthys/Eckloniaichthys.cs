using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Eckloniaichthys;

/// <summary>
/// Abstract class for Eckloniaichthys (genus).
/// NCBI TaxId: 2740786
/// </summary>
public abstract class Eckloniaichthys : Gobiesocidae, IEckloniaichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eckloniaichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740786;

    /// <inheritdoc />
    public virtual string GenusName => "Eckloniaichthys";

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
