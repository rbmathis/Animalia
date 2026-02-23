using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Pseudochaenichthys;

/// <summary>
/// Abstract class for Pseudochaenichthys (genus).
/// NCBI TaxId: 52238
/// </summary>
public abstract class Pseudochaenichthys : Channichthyidae, IPseudochaenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudochaenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52238;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudochaenichthys";

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
