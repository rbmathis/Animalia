using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Tautoga;

/// <summary>
/// Abstract class for Tautoga (genus).
/// NCBI TaxId: 202601
/// </summary>
public abstract class Tautoga : Labridae, ITautoga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tautoga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202601;

    /// <inheritdoc />
    public virtual string GenusName => "Tautoga";

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
