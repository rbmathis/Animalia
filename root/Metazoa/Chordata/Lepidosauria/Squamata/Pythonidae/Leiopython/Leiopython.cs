using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Leiopython;

/// <summary>
/// Abstract class for Leiopython (genus).
/// NCBI TaxId: 3144915
/// </summary>
public abstract class Leiopython : Pythonidae, ILeiopython
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiopython";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3144915;

    /// <inheritdoc />
    public virtual string GenusName => "Leiopython";

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
