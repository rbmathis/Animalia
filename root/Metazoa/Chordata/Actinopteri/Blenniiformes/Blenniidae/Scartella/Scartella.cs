using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Scartella;

/// <summary>
/// Abstract class for Scartella (genus).
/// NCBI TaxId: 195083
/// </summary>
public abstract class Scartella : Blenniidae, IScartella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scartella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195083;

    /// <inheritdoc />
    public virtual string GenusName => "Scartella";

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
