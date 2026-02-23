using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Cephalorhynchus;

/// <summary>
/// Abstract class for Cephalorhynchus (genus).
/// NCBI TaxId: 27607
/// </summary>
public abstract class Cephalorhynchus : Delphinidae, ICephalorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27607;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalorhynchus";

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
