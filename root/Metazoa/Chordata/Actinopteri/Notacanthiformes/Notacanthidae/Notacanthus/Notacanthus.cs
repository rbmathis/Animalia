using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Notacanthus;

/// <summary>
/// Abstract class for Notacanthus (genus).
/// NCBI TaxId: 55112
/// </summary>
public abstract class Notacanthus : Notacanthidae, INotacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55112;

    /// <inheritdoc />
    public virtual string GenusName => "Notacanthus";

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
