using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Ogilbichthys;

/// <summary>
/// Abstract class for Ogilbichthys (genus).
/// NCBI TaxId: 1182247
/// </summary>
public abstract class Ogilbichthys : Bythitidae, IOgilbichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ogilbichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182247;

    /// <inheritdoc />
    public virtual string GenusName => "Ogilbichthys";

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
