using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Chlamydogobius;

/// <summary>
/// Abstract class for Chlamydogobius (genus).
/// NCBI TaxId: 1365675
/// </summary>
public abstract class Chlamydogobius : Gobiidae, IChlamydogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamydogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365675;

    /// <inheritdoc />
    public virtual string GenusName => "Chlamydogobius";

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
