using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Pseudophallus;

/// <summary>
/// Abstract class for Pseudophallus (genus).
/// NCBI TaxId: 1914736
/// </summary>
public abstract class Pseudophallus : Syngnathidae, IPseudophallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudophallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914736;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudophallus";

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
