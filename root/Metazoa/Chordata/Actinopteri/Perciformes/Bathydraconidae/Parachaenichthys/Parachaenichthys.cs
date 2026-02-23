using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Parachaenichthys;

/// <summary>
/// Abstract class for Parachaenichthys (genus).
/// NCBI TaxId: 36186
/// </summary>
public abstract class Parachaenichthys : Bathydraconidae, IParachaenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachaenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36186;

    /// <inheritdoc />
    public virtual string GenusName => "Parachaenichthys";

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
