using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Hypselognathus;

/// <summary>
/// Abstract class for Hypselognathus (genus).
/// NCBI TaxId: 161461
/// </summary>
public abstract class Hypselognathus : Syngnathidae, IHypselognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypselognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161461;

    /// <inheritdoc />
    public virtual string GenusName => "Hypselognathus";

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
