using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Baryancistrus;

/// <summary>
/// Abstract class for Baryancistrus (genus).
/// NCBI TaxId: 281759
/// </summary>
public abstract class Baryancistrus : Loricariidae, IBaryancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baryancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281759;

    /// <inheritdoc />
    public virtual string GenusName => "Baryancistrus";

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
