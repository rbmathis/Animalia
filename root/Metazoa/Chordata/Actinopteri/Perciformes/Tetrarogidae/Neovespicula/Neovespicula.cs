using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Neovespicula;

/// <summary>
/// Abstract class for Neovespicula (genus).
/// NCBI TaxId: 2057079
/// </summary>
public abstract class Neovespicula : Tetrarogidae, INeovespicula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neovespicula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2057079;

    /// <inheritdoc />
    public virtual string GenusName => "Neovespicula";

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
