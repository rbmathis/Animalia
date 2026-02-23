using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Entomacrodus;

/// <summary>
/// Abstract class for Entomacrodus (genus).
/// NCBI TaxId: 57795
/// </summary>
public abstract class Entomacrodus : Blenniidae, IEntomacrodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Entomacrodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57795;

    /// <inheritdoc />
    public virtual string GenusName => "Entomacrodus";

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
