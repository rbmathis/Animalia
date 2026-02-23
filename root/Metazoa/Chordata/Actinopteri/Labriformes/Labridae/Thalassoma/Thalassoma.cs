using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Thalassoma;

/// <summary>
/// Abstract class for Thalassoma (genus).
/// NCBI TaxId: 76337
/// </summary>
public abstract class Thalassoma : Labridae, IThalassoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalassoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76337;

    /// <inheritdoc />
    public virtual string GenusName => "Thalassoma";

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
