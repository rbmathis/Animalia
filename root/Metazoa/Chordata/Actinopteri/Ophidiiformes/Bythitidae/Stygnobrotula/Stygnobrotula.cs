using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Stygnobrotula;

/// <summary>
/// Abstract class for Stygnobrotula (genus).
/// NCBI TaxId: 980628
/// </summary>
public abstract class Stygnobrotula : Bythitidae, IStygnobrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stygnobrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980628;

    /// <inheritdoc />
    public virtual string GenusName => "Stygnobrotula";

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
