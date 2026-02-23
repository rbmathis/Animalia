using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Paraheminodus;

/// <summary>
/// Abstract class for Paraheminodus (genus).
/// NCBI TaxId: 1306747
/// </summary>
public abstract class Paraheminodus : Peristediidae, IParaheminodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraheminodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306747;

    /// <inheritdoc />
    public virtual string GenusName => "Paraheminodus";

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
