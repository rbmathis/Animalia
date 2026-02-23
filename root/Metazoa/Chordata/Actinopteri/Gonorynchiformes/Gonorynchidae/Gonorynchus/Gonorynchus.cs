using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Gonorynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Gonorynchidae.Gonorynchus;

/// <summary>
/// Abstract class for Gonorynchus (genus).
/// NCBI TaxId: 149984
/// </summary>
public abstract class Gonorynchus : Gonorynchidae, IGonorynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonorynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 149984;

    /// <inheritdoc />
    public virtual string GenusName => "Gonorynchus";

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
