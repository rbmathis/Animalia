using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Bythites;

/// <summary>
/// Abstract class for Bythites (genus).
/// NCBI TaxId: 1263169
/// </summary>
public abstract class Bythites : Bythitidae, IBythites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bythites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1263169;

    /// <inheritdoc />
    public virtual string GenusName => "Bythites";

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
