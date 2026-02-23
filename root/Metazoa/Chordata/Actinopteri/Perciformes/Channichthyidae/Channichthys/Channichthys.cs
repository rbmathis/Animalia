using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Channichthys;

/// <summary>
/// Abstract class for Channichthys (genus).
/// NCBI TaxId: 70437
/// </summary>
public abstract class Channichthys : Channichthyidae, IChannichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Channichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70437;

    /// <inheritdoc />
    public virtual string GenusName => "Channichthys";

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
