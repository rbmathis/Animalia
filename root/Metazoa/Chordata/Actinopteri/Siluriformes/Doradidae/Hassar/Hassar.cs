using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Hassar;

/// <summary>
/// Abstract class for Hassar (genus).
/// NCBI TaxId: 238609
/// </summary>
public abstract class Hassar : Doradidae, IHassar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hassar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238609;

    /// <inheritdoc />
    public virtual string GenusName => "Hassar";

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
