using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Bathyclarias;

/// <summary>
/// Abstract class for Bathyclarias (genus).
/// NCBI TaxId: 125849
/// </summary>
public abstract class Bathyclarias : Clariidae, IBathyclarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyclarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125849;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyclarias";

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
