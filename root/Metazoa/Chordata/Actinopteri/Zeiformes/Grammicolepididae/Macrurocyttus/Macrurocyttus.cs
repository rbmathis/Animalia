using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae.Macrurocyttus;

/// <summary>
/// Abstract class for Macrurocyttus (genus).
/// NCBI TaxId: 3362373
/// </summary>
public abstract class Macrurocyttus : Grammicolepididae, IMacrurocyttus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrurocyttus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362373;

    /// <inheritdoc />
    public virtual string GenusName => "Macrurocyttus";

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
