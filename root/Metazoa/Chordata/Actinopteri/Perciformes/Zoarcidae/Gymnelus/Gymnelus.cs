using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Gymnelus;

/// <summary>
/// Abstract class for Gymnelus (genus).
/// NCBI TaxId: 932716
/// </summary>
public abstract class Gymnelus : Zoarcidae, IGymnelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 932716;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnelus";

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
