using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Erythrinus;

/// <summary>
/// Abstract class for Erythrinus (genus).
/// NCBI TaxId: 754153
/// </summary>
public abstract class Erythrinus : Erythrinidae, IErythrinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 754153;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrinus";

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
