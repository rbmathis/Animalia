using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Monacanthus;

/// <summary>
/// Abstract class for Monacanthus (genus).
/// NCBI TaxId: 303714
/// </summary>
public abstract class Monacanthus : Monacanthidae, IMonacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303714;

    /// <inheritdoc />
    public virtual string GenusName => "Monacanthus";

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
