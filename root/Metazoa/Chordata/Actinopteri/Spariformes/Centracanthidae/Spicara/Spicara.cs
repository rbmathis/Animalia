using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Spicara;

/// <summary>
/// Abstract class for Spicara (genus).
/// NCBI TaxId: 98822
/// </summary>
public abstract class Spicara : Centracanthidae, ISpicara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spicara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98822;

    /// <inheritdoc />
    public virtual string GenusName => "Spicara";

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
