using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Amniataba;

/// <summary>
/// Abstract class for Amniataba (genus).
/// NCBI TaxId: 1161366
/// </summary>
public abstract class Amniataba : Terapontidae, IAmniataba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amniataba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1161366;

    /// <inheritdoc />
    public virtual string GenusName => "Amniataba";

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
