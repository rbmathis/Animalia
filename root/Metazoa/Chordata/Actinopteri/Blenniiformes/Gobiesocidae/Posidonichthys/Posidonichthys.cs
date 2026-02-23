using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Posidonichthys;

/// <summary>
/// Abstract class for Posidonichthys (genus).
/// NCBI TaxId: 2740777
/// </summary>
public abstract class Posidonichthys : Gobiesocidae, IPosidonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Posidonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740777;

    /// <inheritdoc />
    public virtual string GenusName => "Posidonichthys";

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
