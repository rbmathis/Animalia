using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hopliancistrus;

/// <summary>
/// Abstract class for Hopliancistrus (genus).
/// NCBI TaxId: 164004
/// </summary>
public abstract class Hopliancistrus : Loricariidae, IHopliancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hopliancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164004;

    /// <inheritdoc />
    public virtual string GenusName => "Hopliancistrus";

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
