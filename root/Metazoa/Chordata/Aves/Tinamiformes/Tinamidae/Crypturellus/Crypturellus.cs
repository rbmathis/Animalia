using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Crypturellus;

/// <summary>
/// Abstract class for Crypturellus (genus).
/// NCBI TaxId: 48395
/// </summary>
public abstract class Crypturellus : Tinamidae, ICrypturellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crypturellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48395;

    /// <inheritdoc />
    public virtual string GenusName => "Crypturellus";

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
