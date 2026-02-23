using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Atrophacanthus;

/// <summary>
/// Abstract class for Atrophacanthus (genus).
/// NCBI TaxId: 2305720
/// </summary>
public abstract class Atrophacanthus : Triacanthodidae, IAtrophacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atrophacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2305720;

    /// <inheritdoc />
    public virtual string GenusName => "Atrophacanthus";

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
