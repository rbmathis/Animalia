using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Cteniloricaria;

/// <summary>
/// Abstract class for Cteniloricaria (genus).
/// NCBI TaxId: 1137654
/// </summary>
public abstract class Cteniloricaria : Loricariidae, ICteniloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cteniloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1137654;

    /// <inheritdoc />
    public virtual string GenusName => "Cteniloricaria";

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
