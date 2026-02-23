using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Meiacanthus;

/// <summary>
/// Abstract class for Meiacanthus (genus).
/// NCBI TaxId: 152544
/// </summary>
public abstract class Meiacanthus : Blenniidae, IMeiacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meiacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 152544;

    /// <inheritdoc />
    public virtual string GenusName => "Meiacanthus";

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
