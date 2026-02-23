using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Diademichthys;

/// <summary>
/// Abstract class for Diademichthys (genus).
/// NCBI TaxId: 1206930
/// </summary>
public abstract class Diademichthys : Gobiesocidae, IDiademichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diademichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206930;

    /// <inheritdoc />
    public virtual string GenusName => "Diademichthys";

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
