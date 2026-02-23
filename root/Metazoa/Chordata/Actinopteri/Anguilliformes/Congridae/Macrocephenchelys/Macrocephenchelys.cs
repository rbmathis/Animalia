using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Macrocephenchelys;

/// <summary>
/// Abstract class for Macrocephenchelys (genus).
/// NCBI TaxId: 391207
/// </summary>
public abstract class Macrocephenchelys : Congridae, IMacrocephenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrocephenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391207;

    /// <inheritdoc />
    public virtual string GenusName => "Macrocephenchelys";

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
