using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Osmerus;

/// <summary>
/// Abstract class for Osmerus (genus).
/// NCBI TaxId: 8013
/// </summary>
public abstract class Osmerus : Osmeridae, IOsmerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osmerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8013;

    /// <inheritdoc />
    public virtual string GenusName => "Osmerus";

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
