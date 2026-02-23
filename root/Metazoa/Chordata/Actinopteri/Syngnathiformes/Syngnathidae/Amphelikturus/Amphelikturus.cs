using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Amphelikturus;

/// <summary>
/// Abstract class for Amphelikturus (genus).
/// NCBI TaxId: 1182853
/// </summary>
public abstract class Amphelikturus : Syngnathidae, IAmphelikturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphelikturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182853;

    /// <inheritdoc />
    public virtual string GenusName => "Amphelikturus";

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
