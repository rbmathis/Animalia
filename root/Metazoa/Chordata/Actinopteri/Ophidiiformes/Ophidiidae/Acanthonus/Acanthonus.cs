using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Acanthonus;

/// <summary>
/// Abstract class for Acanthonus (genus).
/// NCBI TaxId: 1843781
/// </summary>
public abstract class Acanthonus : Ophidiidae, IAcanthonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843781;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthonus";

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
