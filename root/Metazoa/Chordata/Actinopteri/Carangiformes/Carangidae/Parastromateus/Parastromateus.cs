using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Parastromateus;

/// <summary>
/// Abstract class for Parastromateus (genus).
/// NCBI TaxId: 435271
/// </summary>
public abstract class Parastromateus : Carangidae, IParastromateus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parastromateus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435271;

    /// <inheritdoc />
    public virtual string GenusName => "Parastromateus";

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
