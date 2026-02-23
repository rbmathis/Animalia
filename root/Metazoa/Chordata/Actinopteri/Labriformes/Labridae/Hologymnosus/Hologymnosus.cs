using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hologymnosus;

/// <summary>
/// Abstract class for Hologymnosus (genus).
/// NCBI TaxId: 241304
/// </summary>
public abstract class Hologymnosus : Labridae, IHologymnosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hologymnosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241304;

    /// <inheritdoc />
    public virtual string GenusName => "Hologymnosus";

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
