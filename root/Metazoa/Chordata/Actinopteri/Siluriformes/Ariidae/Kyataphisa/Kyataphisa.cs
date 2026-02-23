using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Kyataphisa;

/// <summary>
/// Abstract class for Kyataphisa (genus).
/// NCBI TaxId: 3363431
/// </summary>
public abstract class Kyataphisa : Ariidae, IKyataphisa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kyataphisa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363431;

    /// <inheritdoc />
    public virtual string GenusName => "Kyataphisa";

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
