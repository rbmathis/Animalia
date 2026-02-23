using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Cataetyx;

/// <summary>
/// Abstract class for Cataetyx (genus).
/// NCBI TaxId: 181403
/// </summary>
public abstract class Cataetyx : Bythitidae, ICataetyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cataetyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181403;

    /// <inheritdoc />
    public virtual string GenusName => "Cataetyx";

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
