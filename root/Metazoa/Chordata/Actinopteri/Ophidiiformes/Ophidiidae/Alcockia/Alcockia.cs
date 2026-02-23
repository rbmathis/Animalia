using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Alcockia;

/// <summary>
/// Abstract class for Alcockia (genus).
/// NCBI TaxId: 3362463
/// </summary>
public abstract class Alcockia : Ophidiidae, IAlcockia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alcockia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362463;

    /// <inheritdoc />
    public virtual string GenusName => "Alcockia";

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
