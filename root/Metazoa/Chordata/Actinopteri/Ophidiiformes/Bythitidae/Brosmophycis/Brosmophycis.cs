using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Brosmophycis;

/// <summary>
/// Abstract class for Brosmophycis (genus).
/// NCBI TaxId: 334376
/// </summary>
public abstract class Brosmophycis : Bythitidae, IBrosmophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brosmophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334376;

    /// <inheritdoc />
    public virtual string GenusName => "Brosmophycis";

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
