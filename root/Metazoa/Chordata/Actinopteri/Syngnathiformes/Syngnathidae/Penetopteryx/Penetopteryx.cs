using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Penetopteryx;

/// <summary>
/// Abstract class for Penetopteryx (genus).
/// NCBI TaxId: 1182209
/// </summary>
public abstract class Penetopteryx : Syngnathidae, IPenetopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Penetopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182209;

    /// <inheritdoc />
    public virtual string GenusName => "Penetopteryx";

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
