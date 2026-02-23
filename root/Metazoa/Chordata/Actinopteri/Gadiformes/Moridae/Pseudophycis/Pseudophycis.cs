using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Pseudophycis;

/// <summary>
/// Abstract class for Pseudophycis (genus).
/// NCBI TaxId: 443805
/// </summary>
public abstract class Pseudophycis : Moridae, IPseudophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443805;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudophycis";

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
