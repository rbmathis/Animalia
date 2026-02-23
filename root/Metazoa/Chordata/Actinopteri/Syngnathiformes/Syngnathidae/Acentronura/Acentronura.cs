using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Acentronura;

/// <summary>
/// Abstract class for Acentronura (genus).
/// NCBI TaxId: 1914710
/// </summary>
public abstract class Acentronura : Syngnathidae, IAcentronura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acentronura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914710;

    /// <inheritdoc />
    public virtual string GenusName => "Acentronura";

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
