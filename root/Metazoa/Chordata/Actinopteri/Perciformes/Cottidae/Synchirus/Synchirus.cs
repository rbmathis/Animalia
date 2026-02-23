using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Synchirus;

/// <summary>
/// Abstract class for Synchirus (genus).
/// NCBI TaxId: 740935
/// </summary>
public abstract class Synchirus : Cottidae, ISynchirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synchirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740935;

    /// <inheritdoc />
    public virtual string GenusName => "Synchirus";

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
