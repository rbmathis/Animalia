using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Phosichthys;

/// <summary>
/// Abstract class for Phosichthys (genus).
/// NCBI TaxId: 707608
/// </summary>
public abstract class Phosichthys : Phosichthyidae, IPhosichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phosichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 707608;

    /// <inheritdoc />
    public virtual string GenusName => "Phosichthys";

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
