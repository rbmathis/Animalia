using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hipposcarus;

/// <summary>
/// Abstract class for Hipposcarus (genus).
/// NCBI TaxId: 188113
/// </summary>
public abstract class Hipposcarus : Labridae, IHipposcarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hipposcarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188113;

    /// <inheritdoc />
    public virtual string GenusName => "Hipposcarus";

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
