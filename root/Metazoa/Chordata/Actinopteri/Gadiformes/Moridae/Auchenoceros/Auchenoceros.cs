using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Auchenoceros;

/// <summary>
/// Abstract class for Auchenoceros (genus).
/// NCBI TaxId: 2696645
/// </summary>
public abstract class Auchenoceros : Moridae, IAuchenoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auchenoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696645;

    /// <inheritdoc />
    public virtual string GenusName => "Auchenoceros";

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
