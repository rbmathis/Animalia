using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae.Acestrorhynchus;

/// <summary>
/// Abstract class for Acestrorhynchus (genus).
/// NCBI TaxId: 42576
/// </summary>
public abstract class Acestrorhynchus : Acestrorhynchidae, IAcestrorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acestrorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42576;

    /// <inheritdoc />
    public virtual string GenusName => "Acestrorhynchus";

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
