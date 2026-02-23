using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lobianchia;

/// <summary>
/// Abstract class for Lobianchia (genus).
/// NCBI TaxId: 123233
/// </summary>
public abstract class Lobianchia : Myctophidae, ILobianchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lobianchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123233;

    /// <inheritdoc />
    public virtual string GenusName => "Lobianchia";

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
