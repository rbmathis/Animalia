using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python;

/// <summary>
/// Abstract class for Python (genus).
/// NCBI TaxId: 37579
/// </summary>
public abstract class Python : Pythonidae, IPython
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Python";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37579;

    /// <inheritdoc />
    public virtual string GenusName => "Python";

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
