using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Arripidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Arripidae.Arripis;

/// <summary>
/// Abstract class for Arripis (genus).
/// NCBI TaxId: 163128
/// </summary>
public abstract class Arripis : Arripidae, IArripis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arripis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163128;

    /// <inheritdoc />
    public virtual string GenusName => "Arripis";

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
