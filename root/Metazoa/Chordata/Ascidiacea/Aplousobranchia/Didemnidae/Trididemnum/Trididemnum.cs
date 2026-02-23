using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Trididemnum;

/// <summary>
/// Abstract class for Trididemnum (genus).
/// NCBI TaxId: 322846
/// </summary>
public abstract class Trididemnum : Didemnidae, ITrididemnum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trididemnum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322846;

    /// <inheritdoc />
    public virtual string GenusName => "Trididemnum";

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
