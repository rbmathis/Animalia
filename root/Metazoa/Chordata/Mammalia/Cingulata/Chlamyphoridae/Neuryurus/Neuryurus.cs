using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Neuryurus;

/// <summary>
/// Abstract class for Neuryurus (genus).
/// NCBI TaxId: 2821560
/// </summary>
public abstract class Neuryurus : Chlamyphoridae, INeuryurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neuryurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821560;

    /// <inheritdoc />
    public virtual string GenusName => "Neuryurus";

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
