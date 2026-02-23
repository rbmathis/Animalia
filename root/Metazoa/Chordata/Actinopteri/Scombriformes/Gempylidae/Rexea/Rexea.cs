using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Rexea;

/// <summary>
/// Abstract class for Rexea (genus).
/// NCBI TaxId: 59945
/// </summary>
public abstract class Rexea : Gempylidae, IRexea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rexea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59945;

    /// <inheritdoc />
    public virtual string GenusName => "Rexea";

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
