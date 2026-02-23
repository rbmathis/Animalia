using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Tetragonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Tetragonuridae.Tetragonurus;

/// <summary>
/// Abstract class for Tetragonurus (genus).
/// NCBI TaxId: 316149
/// </summary>
public abstract class Tetragonurus : Tetragonuridae, ITetragonurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetragonurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316149;

    /// <inheritdoc />
    public virtual string GenusName => "Tetragonurus";

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
