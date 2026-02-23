using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Doedicurus;

/// <summary>
/// Abstract class for Doedicurus (genus).
/// NCBI TaxId: 1811494
/// </summary>
public abstract class Doedicurus : Chlamyphoridae, IDoedicurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doedicurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1811494;

    /// <inheritdoc />
    public virtual string GenusName => "Doedicurus";

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
