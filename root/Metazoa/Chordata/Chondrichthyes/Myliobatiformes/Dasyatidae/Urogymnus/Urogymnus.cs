using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Urogymnus;

/// <summary>
/// Abstract class for Urogymnus (genus).
/// NCBI TaxId: 117835
/// </summary>
public abstract class Urogymnus : Dasyatidae, IUrogymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urogymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117835;

    /// <inheritdoc />
    public virtual string GenusName => "Urogymnus";

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
