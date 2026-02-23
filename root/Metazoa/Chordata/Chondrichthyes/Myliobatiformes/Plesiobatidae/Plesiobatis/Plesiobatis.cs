using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Plesiobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Plesiobatidae.Plesiobatis;

/// <summary>
/// Abstract class for Plesiobatis (genus).
/// NCBI TaxId: 117841
/// </summary>
public abstract class Plesiobatis : Plesiobatidae, IPlesiobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117841;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiobatis";

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
