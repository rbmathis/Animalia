using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Notophycis;

/// <summary>
/// Abstract class for Notophycis (genus).
/// NCBI TaxId: 458589
/// </summary>
public abstract class Notophycis : Moridae, INotophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458589;

    /// <inheritdoc />
    public virtual string GenusName => "Notophycis";

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
