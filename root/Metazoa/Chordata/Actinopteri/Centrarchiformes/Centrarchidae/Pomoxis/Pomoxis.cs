using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Pomoxis;

/// <summary>
/// Abstract class for Pomoxis (genus).
/// NCBI TaxId: 8181
/// </summary>
public abstract class Pomoxis : Centrarchidae, IPomoxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomoxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8181;

    /// <inheritdoc />
    public virtual string GenusName => "Pomoxis";

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
