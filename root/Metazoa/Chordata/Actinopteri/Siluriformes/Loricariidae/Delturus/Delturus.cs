using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Delturus;

/// <summary>
/// Abstract class for Delturus (genus).
/// NCBI TaxId: 245751
/// </summary>
public abstract class Delturus : Loricariidae, IDelturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245751;

    /// <inheritdoc />
    public virtual string GenusName => "Delturus";

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
