using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Allosmerus;

/// <summary>
/// Abstract class for Allosmerus (genus).
/// NCBI TaxId: 182232
/// </summary>
public abstract class Allosmerus : Osmeridae, IAllosmerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allosmerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182232;

    /// <inheritdoc />
    public virtual string GenusName => "Allosmerus";

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
