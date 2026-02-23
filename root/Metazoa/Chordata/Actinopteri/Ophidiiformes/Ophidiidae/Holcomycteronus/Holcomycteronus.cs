using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Holcomycteronus;

/// <summary>
/// Abstract class for Holcomycteronus (genus).
/// NCBI TaxId: 1843791
/// </summary>
public abstract class Holcomycteronus : Ophidiidae, IHolcomycteronus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holcomycteronus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843791;

    /// <inheritdoc />
    public virtual string GenusName => "Holcomycteronus";

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
