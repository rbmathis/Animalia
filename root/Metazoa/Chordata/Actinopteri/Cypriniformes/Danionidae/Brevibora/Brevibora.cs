using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Brevibora;

/// <summary>
/// Abstract class for Brevibora (genus).
/// NCBI TaxId: 1142235
/// </summary>
public abstract class Brevibora : Danionidae, IBrevibora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brevibora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1142235;

    /// <inheritdoc />
    public virtual string GenusName => "Brevibora";

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
