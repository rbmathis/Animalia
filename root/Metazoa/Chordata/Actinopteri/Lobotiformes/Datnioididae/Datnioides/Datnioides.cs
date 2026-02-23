using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Datnioididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Datnioididae.Datnioides;

/// <summary>
/// Abstract class for Datnioides (genus).
/// NCBI TaxId: 428445
/// </summary>
public abstract class Datnioides : Datnioididae, IDatnioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Datnioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428445;

    /// <inheritdoc />
    public virtual string GenusName => "Datnioides";

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
