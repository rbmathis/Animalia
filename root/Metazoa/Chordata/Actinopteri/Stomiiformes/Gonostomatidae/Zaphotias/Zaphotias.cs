using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Zaphotias;

/// <summary>
/// Abstract class for Zaphotias (genus).
/// NCBI TaxId: 3363503
/// </summary>
public abstract class Zaphotias : Gonostomatidae, IZaphotias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zaphotias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363503;

    /// <inheritdoc />
    public virtual string GenusName => "Zaphotias";

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
