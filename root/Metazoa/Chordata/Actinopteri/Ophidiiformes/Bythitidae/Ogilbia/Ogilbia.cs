using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Ogilbia;

/// <summary>
/// Abstract class for Ogilbia (genus).
/// NCBI TaxId: 722520
/// </summary>
public abstract class Ogilbia : Bythitidae, IOgilbia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ogilbia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722520;

    /// <inheritdoc />
    public virtual string GenusName => "Ogilbia";

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
