using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Chlorurus;

/// <summary>
/// Abstract class for Chlorurus (genus).
/// NCBI TaxId: 126670
/// </summary>
public abstract class Chlorurus : Labridae, IChlorurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126670;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorurus";

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
