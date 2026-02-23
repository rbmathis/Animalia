using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pastinachus;

/// <summary>
/// Abstract class for Pastinachus (genus).
/// NCBI TaxId: 87137
/// </summary>
public abstract class Pastinachus : Dasyatidae, IPastinachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pastinachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87137;

    /// <inheritdoc />
    public virtual string GenusName => "Pastinachus";

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
