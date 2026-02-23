using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Notoglanidium;

/// <summary>
/// Abstract class for Notoglanidium (genus).
/// NCBI TaxId: 2485737
/// </summary>
public abstract class Notoglanidium : Auchenoglanididae, INotoglanidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoglanidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485737;

    /// <inheritdoc />
    public virtual string GenusName => "Notoglanidium";

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
