using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Pugnaso;

/// <summary>
/// Abstract class for Pugnaso (genus).
/// NCBI TaxId: 161470
/// </summary>
public abstract class Pugnaso : Syngnathidae, IPugnaso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pugnaso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161470;

    /// <inheritdoc />
    public virtual string GenusName => "Pugnaso";

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
