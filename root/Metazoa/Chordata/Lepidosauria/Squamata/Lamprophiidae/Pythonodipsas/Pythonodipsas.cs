using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Pythonodipsas;

/// <summary>
/// Abstract class for Pythonodipsas (genus).
/// NCBI TaxId: 224569
/// </summary>
public abstract class Pythonodipsas : Lamprophiidae, IPythonodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pythonodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224569;

    /// <inheritdoc />
    public virtual string GenusName => "Pythonodipsas";

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
