using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Gonostoma;

/// <summary>
/// Abstract class for Gonostoma (genus).
/// NCBI TaxId: 48455
/// </summary>
public abstract class Gonostoma : Gonostomatidae, IGonostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48455;

    /// <inheritdoc />
    public virtual string GenusName => "Gonostoma";

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
