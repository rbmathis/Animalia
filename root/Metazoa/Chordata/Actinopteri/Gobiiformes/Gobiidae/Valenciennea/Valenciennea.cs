using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Valenciennea;

/// <summary>
/// Abstract class for Valenciennea (genus).
/// NCBI TaxId: 150331
/// </summary>
public abstract class Valenciennea : Gobiidae, IValenciennea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Valenciennea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150331;

    /// <inheritdoc />
    public virtual string GenusName => "Valenciennea";

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
