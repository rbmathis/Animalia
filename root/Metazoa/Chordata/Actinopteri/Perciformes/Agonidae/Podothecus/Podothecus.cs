using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Podothecus;

/// <summary>
/// Abstract class for Podothecus (genus).
/// NCBI TaxId: 255532
/// </summary>
public abstract class Podothecus : Agonidae, IPodothecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podothecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255532;

    /// <inheritdoc />
    public virtual string GenusName => "Podothecus";

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
