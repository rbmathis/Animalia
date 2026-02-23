using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Idiotropiscis;

/// <summary>
/// Abstract class for Idiotropiscis (genus).
/// NCBI TaxId: 642997
/// </summary>
public abstract class Idiotropiscis : Syngnathidae, IIdiotropiscis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idiotropiscis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642997;

    /// <inheritdoc />
    public virtual string GenusName => "Idiotropiscis";

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
