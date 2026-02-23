using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Gymnuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Gymnuridae.Gymnura;

/// <summary>
/// Abstract class for Gymnura (genus).
/// NCBI TaxId: 86360
/// </summary>
public abstract class Gymnura : Gymnuridae, IGymnura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86360;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnura";

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
