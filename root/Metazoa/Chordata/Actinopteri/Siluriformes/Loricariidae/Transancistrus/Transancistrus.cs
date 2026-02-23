using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Transancistrus;

/// <summary>
/// Abstract class for Transancistrus (genus).
/// NCBI TaxId: 2993303
/// </summary>
public abstract class Transancistrus : Loricariidae, ITransancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Transancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2993303;

    /// <inheritdoc />
    public virtual string GenusName => "Transancistrus";

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
