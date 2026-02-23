using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Syngnathoides;

/// <summary>
/// Abstract class for Syngnathoides (genus).
/// NCBI TaxId: 300416
/// </summary>
public abstract class Syngnathoides : Syngnathidae, ISyngnathoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syngnathoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300416;

    /// <inheritdoc />
    public virtual string GenusName => "Syngnathoides";

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
