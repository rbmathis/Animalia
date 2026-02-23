using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Triacanthus;

/// <summary>
/// Abstract class for Triacanthus (genus).
/// NCBI TaxId: 384594
/// </summary>
public abstract class Triacanthus : Triacanthidae, ITriacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 384594;

    /// <inheritdoc />
    public virtual string GenusName => "Triacanthus";

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
