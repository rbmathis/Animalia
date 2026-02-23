using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Aulacocephalus;

/// <summary>
/// Abstract class for Aulacocephalus (genus).
/// NCBI TaxId: 990935
/// </summary>
public abstract class Aulacocephalus : Serranidae, IAulacocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulacocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990935;

    /// <inheritdoc />
    public virtual string GenusName => "Aulacocephalus";

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
