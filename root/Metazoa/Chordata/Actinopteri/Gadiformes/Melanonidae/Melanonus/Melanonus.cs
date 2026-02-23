using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Melanonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Melanonidae.Melanonus;

/// <summary>
/// Abstract class for Melanonus (genus).
/// NCBI TaxId: 181409
/// </summary>
public abstract class Melanonus : Melanonidae, IMelanonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181409;

    /// <inheritdoc />
    public virtual string GenusName => "Melanonus";

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
