using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pateobatis;

/// <summary>
/// Abstract class for Pateobatis (genus).
/// NCBI TaxId: 2212484
/// </summary>
public abstract class Pateobatis : Dasyatidae, IPateobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pateobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2212484;

    /// <inheritdoc />
    public virtual string GenusName => "Pateobatis";

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
