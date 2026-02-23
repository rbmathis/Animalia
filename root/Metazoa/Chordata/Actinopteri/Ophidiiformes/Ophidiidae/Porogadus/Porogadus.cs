using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Porogadus;

/// <summary>
/// Abstract class for Porogadus (genus).
/// NCBI TaxId: 1459853
/// </summary>
public abstract class Porogadus : Ophidiidae, IPorogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1459853;

    /// <inheritdoc />
    public virtual string GenusName => "Porogadus";

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
