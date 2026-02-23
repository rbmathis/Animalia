using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Corumbataia;

/// <summary>
/// Abstract class for Corumbataia (genus).
/// NCBI TaxId: 510925
/// </summary>
public abstract class Corumbataia : Loricariidae, ICorumbataia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corumbataia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510925;

    /// <inheritdoc />
    public virtual string GenusName => "Corumbataia";

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
