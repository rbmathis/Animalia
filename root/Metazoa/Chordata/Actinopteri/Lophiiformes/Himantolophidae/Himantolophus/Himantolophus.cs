using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Himantolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Himantolophidae.Himantolophus;

/// <summary>
/// Abstract class for Himantolophus (genus).
/// NCBI TaxId: 242960
/// </summary>
public abstract class Himantolophus : Himantolophidae, IHimantolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Himantolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242960;

    /// <inheritdoc />
    public virtual string GenusName => "Himantolophus";

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
