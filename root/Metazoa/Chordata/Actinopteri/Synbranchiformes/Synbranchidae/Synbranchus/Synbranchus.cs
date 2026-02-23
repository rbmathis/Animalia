using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Synbranchus;

/// <summary>
/// Abstract class for Synbranchus (genus).
/// NCBI TaxId: 181451
/// </summary>
public abstract class Synbranchus : Synbranchidae, ISynbranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synbranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181451;

    /// <inheritdoc />
    public virtual string GenusName => "Synbranchus";

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
