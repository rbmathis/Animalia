using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Etheostoma;

/// <summary>
/// Abstract class for Etheostoma (genus).
/// NCBI TaxId: 54318
/// </summary>
public abstract class Etheostoma : Percidae, IEtheostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Etheostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54318;

    /// <inheritdoc />
    public virtual string GenusName => "Etheostoma";

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
