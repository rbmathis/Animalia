using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Dasyatis;

/// <summary>
/// Abstract class for Dasyatis (genus).
/// NCBI TaxId: 32439
/// </summary>
public abstract class Dasyatis : Dasyatidae, IDasyatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasyatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32439;

    /// <inheritdoc />
    public virtual string GenusName => "Dasyatis";

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
