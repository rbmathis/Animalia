using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Diplacanthopoma;

/// <summary>
/// Abstract class for Diplacanthopoma (genus).
/// NCBI TaxId: 181405
/// </summary>
public abstract class Diplacanthopoma : Bythitidae, IDiplacanthopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplacanthopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181405;

    /// <inheritdoc />
    public virtual string GenusName => "Diplacanthopoma";

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
