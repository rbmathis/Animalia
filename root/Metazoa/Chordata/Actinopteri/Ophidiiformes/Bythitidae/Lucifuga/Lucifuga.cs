using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Lucifuga;

/// <summary>
/// Abstract class for Lucifuga (genus).
/// NCBI TaxId: 670422
/// </summary>
public abstract class Lucifuga : Bythitidae, ILucifuga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lucifuga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 670422;

    /// <inheritdoc />
    public virtual string GenusName => "Lucifuga";

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
