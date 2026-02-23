using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Priodontes;

/// <summary>
/// Abstract class for Priodontes (genus).
/// NCBI TaxId: 183751
/// </summary>
public abstract class Priodontes : Chlamyphoridae, IPriodontes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priodontes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183751;

    /// <inheritdoc />
    public virtual string GenusName => "Priodontes";

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
