using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Neurotrichus;

/// <summary>
/// Abstract class for Neurotrichus (genus).
/// NCBI TaxId: 182676
/// </summary>
public abstract class Neurotrichus : Talpidae, INeurotrichus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neurotrichus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182676;

    /// <inheritdoc />
    public virtual string GenusName => "Neurotrichus";

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
